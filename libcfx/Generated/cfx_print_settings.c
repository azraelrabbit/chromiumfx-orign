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


// cef_print_settings

#ifdef __cplusplus
extern "C" {
#endif

// CEF_EXPORT cef_print_settings_t* cef_print_settings_create();
CFX_EXPORT cef_print_settings_t* cfx_print_settings_create() {
    return cef_print_settings_create();
}
// cef_base_t base

// is_valid
CFX_EXPORT int cfx_print_settings_is_valid(cef_print_settings_t* self) {
    return self->is_valid(self);
}

// is_read_only
CFX_EXPORT int cfx_print_settings_is_read_only(cef_print_settings_t* self) {
    return self->is_read_only(self);
}

// copy
CFX_EXPORT cef_print_settings_t* cfx_print_settings_copy(cef_print_settings_t* self) {
    return self->copy(self);
}

// set_orientation
CFX_EXPORT void cfx_print_settings_set_orientation(cef_print_settings_t* self, int landscape) {
    self->set_orientation(self, landscape);
}

// is_landscape
CFX_EXPORT int cfx_print_settings_is_landscape(cef_print_settings_t* self) {
    return self->is_landscape(self);
}

// set_printer_printable_area
CFX_EXPORT void cfx_print_settings_set_printer_printable_area(cef_print_settings_t* self, const cef_size_t* physical_size_device_units, const cef_rect_t* printable_area_device_units, int landscape_needs_flip) {
    self->set_printer_printable_area(self, physical_size_device_units, printable_area_device_units, landscape_needs_flip);
}

// set_device_name
CFX_EXPORT void cfx_print_settings_set_device_name(cef_print_settings_t* self, char16 *name_str, int name_length) {
    cef_string_t name = { name_str, name_length, 0 };
    self->set_device_name(self, &name);
}

// get_device_name
CFX_EXPORT cef_string_userfree_t cfx_print_settings_get_device_name(cef_print_settings_t* self) {
    return self->get_device_name(self);
}

// set_dpi
CFX_EXPORT void cfx_print_settings_set_dpi(cef_print_settings_t* self, int dpi) {
    self->set_dpi(self, dpi);
}

// get_dpi
CFX_EXPORT int cfx_print_settings_get_dpi(cef_print_settings_t* self) {
    return self->get_dpi(self);
}

// set_page_ranges
CFX_EXPORT void cfx_print_settings_set_page_ranges(cef_print_settings_t* self, int rangesCount, cef_page_range_t const* ranges) {
    self->set_page_ranges(self, (size_t)(rangesCount), ranges);
}

// get_page_ranges_count
CFX_EXPORT int cfx_print_settings_get_page_ranges_count(cef_print_settings_t* self) {
    return (int)(self->get_page_ranges_count(self));
}

// get_page_ranges
CFX_EXPORT void cfx_print_settings_get_page_ranges(cef_print_settings_t* self, size_t* rangesCount, cef_page_range_t* ranges) {
    self->get_page_ranges(self, rangesCount, ranges);
}

// set_selection_only
CFX_EXPORT void cfx_print_settings_set_selection_only(cef_print_settings_t* self, int selection_only) {
    self->set_selection_only(self, selection_only);
}

// is_selection_only
CFX_EXPORT int cfx_print_settings_is_selection_only(cef_print_settings_t* self) {
    return self->is_selection_only(self);
}

// set_collate
CFX_EXPORT void cfx_print_settings_set_collate(cef_print_settings_t* self, int collate) {
    self->set_collate(self, collate);
}

// will_collate
CFX_EXPORT int cfx_print_settings_will_collate(cef_print_settings_t* self) {
    return self->will_collate(self);
}

// set_color_model
CFX_EXPORT void cfx_print_settings_set_color_model(cef_print_settings_t* self, cef_color_model_t model) {
    self->set_color_model(self, model);
}

// get_color_model
CFX_EXPORT cef_color_model_t cfx_print_settings_get_color_model(cef_print_settings_t* self) {
    return self->get_color_model(self);
}

// set_copies
CFX_EXPORT void cfx_print_settings_set_copies(cef_print_settings_t* self, int copies) {
    self->set_copies(self, copies);
}

// get_copies
CFX_EXPORT int cfx_print_settings_get_copies(cef_print_settings_t* self) {
    return self->get_copies(self);
}

// set_duplex_mode
CFX_EXPORT void cfx_print_settings_set_duplex_mode(cef_print_settings_t* self, cef_duplex_mode_t mode) {
    self->set_duplex_mode(self, mode);
}

// get_duplex_mode
CFX_EXPORT cef_duplex_mode_t cfx_print_settings_get_duplex_mode(cef_print_settings_t* self) {
    return self->get_duplex_mode(self);
}


#ifdef __cplusplus
} // extern "C"
#endif

