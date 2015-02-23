// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium {
    /// <summary>
    /// Callback structure for cef_browser_host_t::GetNavigationEntries. The
    /// functions of this structure will be called on the browser process UI thread.
    /// </summary>
    public class CfxNavigationEntryVisitor : CfxBase {

        internal static CfxNavigationEntryVisitor Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_navigation_entry_visitor_get_gc_handle(nativePtr);
            return (CfxNavigationEntryVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void visit(IntPtr gcHandlePtr, out int __retval, IntPtr entry, int current, int index, int total) {
            var self = (CfxNavigationEntryVisitor)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxNavigationEntryVisitorVisitEventArgs(entry, current, index, total);
            var eventHandler = self.m_Visit;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_entry_wrapped == null) CfxApi.cfx_release(e.m_entry);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal CfxNavigationEntryVisitor(IntPtr nativePtr) : base(nativePtr) {}
        public CfxNavigationEntryVisitor() : base(CfxApi.cfx_navigation_entry_visitor_ctor) {}

        /// <summary>
        /// Method that will be executed. Do not keep a reference to |entry| outside of
        /// this callback. Return true (1) to continue visiting entries or false (0) to
        /// stop. |current| is true (1) if this entry is the currently loaded
        /// navigation entry. |index| is the 0-based index of this entry and |total| is
        /// the total number of entries.
        /// </summary>
        public event CfxNavigationEntryVisitorVisitEventHandler Visit {
            add {
                if(m_Visit == null) {
                    CfxApi.cfx_navigation_entry_visitor_activate_callback(NativePtr, 0, 1);
                }
                m_Visit += value;
            }
            remove {
                m_Visit -= value;
                if(m_Visit == null) {
                    CfxApi.cfx_navigation_entry_visitor_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxNavigationEntryVisitorVisitEventHandler m_Visit;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_Visit != null) {
                m_Visit = null;
                CfxApi.cfx_navigation_entry_visitor_activate_callback(NativePtr, 0, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    public delegate void CfxNavigationEntryVisitorVisitEventHandler(object sender, CfxNavigationEntryVisitorVisitEventArgs e);

    /// <summary>
    /// Method that will be executed. Do not keep a reference to |entry| outside of
    /// this callback. Return true (1) to continue visiting entries or false (0) to
    /// stop. |current| is true (1) if this entry is the currently loaded
    /// navigation entry. |index| is the 0-based index of this entry and |total| is
    /// the total number of entries.
    /// </summary>
    public class CfxNavigationEntryVisitorVisitEventArgs : CfxEventArgs {

        internal IntPtr m_entry;
        internal CfxNavigationEntry m_entry_wrapped;
        internal int m_current;
        internal int m_index;
        internal int m_total;

        internal bool m_returnValue;
        private bool returnValueSet;

        internal CfxNavigationEntryVisitorVisitEventArgs(IntPtr entry, int current, int index, int total) {
            m_entry = entry;
            m_current = current;
            m_index = index;
            m_total = total;
        }

        public CfxNavigationEntry Entry {
            get {
                CheckAccess();
                if(m_entry_wrapped == null) m_entry_wrapped = CfxNavigationEntry.Wrap(m_entry);
                return m_entry_wrapped;
            }
        }
        public bool Current {
            get {
                CheckAccess();
                return 0 != m_current;
            }
        }
        public int Index {
            get {
                CheckAccess();
                return m_index;
            }
        }
        public int Total {
            get {
                CheckAccess();
                return m_total;
            }
        }
        public void SetReturnValue(bool returnValue) {
            CheckAccess();
            if(returnValueSet) {
                throw new CfxException("The return value has already been set");
            }
            returnValueSet = true;
            this.m_returnValue = returnValue;
        }

        public override string ToString() {
            return String.Format("Entry={{{0}}}, Current={{{1}}}, Index={{{2}}}, Total={{{3}}}", Entry, Current, Index, Total);
        }
    }

}