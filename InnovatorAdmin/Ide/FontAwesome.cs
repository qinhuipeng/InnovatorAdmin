﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InnovatorAdmin
{
  public class FontAwesome
  {
    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

    private static Font _font;
    private static FontFamily _family;

    #region Characters
    public static char Fa_500px = '\xf26e';
    public static char Fa_adjust = '\xf042';
    public static char Fa_adn = '\xf170';
    public static char Fa_align_center = '\xf037';
    public static char Fa_align_justify = '\xf039';
    public static char Fa_align_left = '\xf036';
    public static char Fa_align_right = '\xf038';
    public static char Fa_amazon = '\xf270';
    public static char Fa_ambulance = '\xf0f9';
    public static char Fa_anchor = '\xf13d';
    public static char Fa_android = '\xf17b';
    public static char Fa_angellist = '\xf209';
    public static char Fa_angle_double_down = '\xf103';
    public static char Fa_angle_double_left = '\xf100';
    public static char Fa_angle_double_right = '\xf101';
    public static char Fa_angle_double_up = '\xf102';
    public static char Fa_angle_down = '\xf107';
    public static char Fa_angle_left = '\xf104';
    public static char Fa_angle_right = '\xf105';
    public static char Fa_angle_up = '\xf106';
    public static char Fa_apple = '\xf179';
    public static char Fa_archive = '\xf187';
    public static char Fa_area_chart = '\xf1fe';
    public static char Fa_arrow_circle_down = '\xf0ab';
    public static char Fa_arrow_circle_left = '\xf0a8';
    public static char Fa_arrow_circle_o_down = '\xf01a';
    public static char Fa_arrow_circle_o_left = '\xf190';
    public static char Fa_arrow_circle_o_right = '\xf18e';
    public static char Fa_arrow_circle_o_up = '\xf01b';
    public static char Fa_arrow_circle_right = '\xf0a9';
    public static char Fa_arrow_circle_up = '\xf0aa';
    public static char Fa_arrow_down = '\xf063';
    public static char Fa_arrow_left = '\xf060';
    public static char Fa_arrow_right = '\xf061';
    public static char Fa_arrow_up = '\xf062';
    public static char Fa_arrows = '\xf047';
    public static char Fa_arrows_alt = '\xf0b2';
    public static char Fa_arrows_h = '\xf07e';
    public static char Fa_arrows_v = '\xf07d';
    public static char Fa_asterisk = '\xf069';
    public static char Fa_at = '\xf1fa';
    public static char Fa_automobile = '\xf1b9';
    public static char Fa_backward = '\xf04a';
    public static char Fa_balance_scale = '\xf24e';
    public static char Fa_ban = '\xf05e';
    public static char Fa_bank = '\xf19c';
    public static char Fa_bar_chart = '\xf080';
    public static char Fa_bar_chart_o = '\xf080';
    public static char Fa_barcode = '\xf02a';
    public static char Fa_bars = '\xf0c9';
    public static char Fa_battery_0 = '\xf244';
    public static char Fa_battery_1 = '\xf243';
    public static char Fa_battery_2 = '\xf242';
    public static char Fa_battery_3 = '\xf241';
    public static char Fa_battery_4 = '\xf240';
    public static char Fa_battery_empty = '\xf244';
    public static char Fa_battery_full = '\xf240';
    public static char Fa_battery_half = '\xf242';
    public static char Fa_battery_quarter = '\xf243';
    public static char Fa_battery_three_quarters = '\xf241';
    public static char Fa_bed = '\xf236';
    public static char Fa_beer = '\xf0fc';
    public static char Fa_behance = '\xf1b4';
    public static char Fa_behance_square = '\xf1b5';
    public static char Fa_bell = '\xf0f3';
    public static char Fa_bell_o = '\xf0a2';
    public static char Fa_bell_slash = '\xf1f6';
    public static char Fa_bell_slash_o = '\xf1f7';
    public static char Fa_bicycle = '\xf206';
    public static char Fa_binoculars = '\xf1e5';
    public static char Fa_birthday_cake = '\xf1fd';
    public static char Fa_bitbucket = '\xf171';
    public static char Fa_bitbucket_square = '\xf172';
    public static char Fa_bitcoin = '\xf15a';
    public static char Fa_black_tie = '\xf27e';
    public static char Fa_bluetooth = '\xf293';
    public static char Fa_bluetooth_b = '\xf294';
    public static char Fa_bold = '\xf032';
    public static char Fa_bolt = '\xf0e7';
    public static char Fa_bomb = '\xf1e2';
    public static char Fa_book = '\xf02d';
    public static char Fa_bookmark = '\xf02e';
    public static char Fa_bookmark_o = '\xf097';
    public static char Fa_briefcase = '\xf0b1';
    public static char Fa_btc = '\xf15a';
    public static char Fa_bug = '\xf188';
    public static char Fa_building = '\xf1ad';
    public static char Fa_building_o = '\xf0f7';
    public static char Fa_bullhorn = '\xf0a1';
    public static char Fa_bullseye = '\xf140';
    public static char Fa_bus = '\xf207';
    public static char Fa_buysellads = '\xf20d';
    public static char Fa_cab = '\xf1ba';
    public static char Fa_calculator = '\xf1ec';
    public static char Fa_calendar = '\xf073';
    public static char Fa_calendar_check_o = '\xf274';
    public static char Fa_calendar_minus_o = '\xf272';
    public static char Fa_calendar_o = '\xf133';
    public static char Fa_calendar_plus_o = '\xf271';
    public static char Fa_calendar_times_o = '\xf273';
    public static char Fa_camera = '\xf030';
    public static char Fa_camera_retro = '\xf083';
    public static char Fa_car = '\xf1b9';
    public static char Fa_caret_down = '\xf0d7';
    public static char Fa_caret_left = '\xf0d9';
    public static char Fa_caret_right = '\xf0da';
    public static char Fa_caret_square_o_down = '\xf150';
    public static char Fa_caret_square_o_left = '\xf191';
    public static char Fa_caret_square_o_right = '\xf152';
    public static char Fa_caret_square_o_up = '\xf151';
    public static char Fa_caret_up = '\xf0d8';
    public static char Fa_cart_arrow_down = '\xf218';
    public static char Fa_cart_plus = '\xf217';
    public static char Fa_cc = '\xf20a';
    public static char Fa_cc_amex = '\xf1f3';
    public static char Fa_cc_diners_club = '\xf24c';
    public static char Fa_cc_discover = '\xf1f2';
    public static char Fa_cc_jcb = '\xf24b';
    public static char Fa_cc_mastercard = '\xf1f1';
    public static char Fa_cc_paypal = '\xf1f4';
    public static char Fa_cc_stripe = '\xf1f5';
    public static char Fa_cc_visa = '\xf1f0';
    public static char Fa_certificate = '\xf0a3';
    public static char Fa_chain = '\xf0c1';
    public static char Fa_chain_broken = '\xf127';
    public static char Fa_check = '\xf00c';
    public static char Fa_check_circle = '\xf058';
    public static char Fa_check_circle_o = '\xf05d';
    public static char Fa_check_square = '\xf14a';
    public static char Fa_check_square_o = '\xf046';
    public static char Fa_chevron_circle_down = '\xf13a';
    public static char Fa_chevron_circle_left = '\xf137';
    public static char Fa_chevron_circle_right = '\xf138';
    public static char Fa_chevron_circle_up = '\xf139';
    public static char Fa_chevron_down = '\xf078';
    public static char Fa_chevron_left = '\xf053';
    public static char Fa_chevron_right = '\xf054';
    public static char Fa_chevron_up = '\xf077';
    public static char Fa_child = '\xf1ae';
    public static char Fa_chrome = '\xf268';
    public static char Fa_circle = '\xf111';
    public static char Fa_circle_o = '\xf10c';
    public static char Fa_circle_o_notch = '\xf1ce';
    public static char Fa_circle_thin = '\xf1db';
    public static char Fa_clipboard = '\xf0ea';
    public static char Fa_clock_o = '\xf017';
    public static char Fa_clone = '\xf24d';
    public static char Fa_close = '\xf00d';
    public static char Fa_cloud = '\xf0c2';
    public static char Fa_cloud_download = '\xf0ed';
    public static char Fa_cloud_upload = '\xf0ee';
    public static char Fa_cny = '\xf157';
    public static char Fa_code = '\xf121';
    public static char Fa_code_fork = '\xf126';
    public static char Fa_codepen = '\xf1cb';
    public static char Fa_codiepie = '\xf284';
    public static char Fa_coffee = '\xf0f4';
    public static char Fa_cog = '\xf013';
    public static char Fa_cogs = '\xf085';
    public static char Fa_columns = '\xf0db';
    public static char Fa_comment = '\xf075';
    public static char Fa_comment_o = '\xf0e5';
    public static char Fa_commenting = '\xf27a';
    public static char Fa_commenting_o = '\xf27b';
    public static char Fa_comments = '\xf086';
    public static char Fa_comments_o = '\xf0e6';
    public static char Fa_compass = '\xf14e';
    public static char Fa_compress = '\xf066';
    public static char Fa_connectdevelop = '\xf20e';
    public static char Fa_contao = '\xf26d';
    public static char Fa_copy = '\xf0c5';
    public static char Fa_copyright = '\xf1f9';
    public static char Fa_creative_commons = '\xf25e';
    public static char Fa_credit_card = '\xf09d';
    public static char Fa_credit_card_alt = '\xf283';
    public static char Fa_crop = '\xf125';
    public static char Fa_crosshairs = '\xf05b';
    public static char Fa_css3 = '\xf13c';
    public static char Fa_cube = '\xf1b2';
    public static char Fa_cubes = '\xf1b3';
    public static char Fa_cut = '\xf0c4';
    public static char Fa_cutlery = '\xf0f5';
    public static char Fa_dashboard = '\xf0e4';
    public static char Fa_dashcube = '\xf210';
    public static char Fa_database = '\xf1c0';
    public static char Fa_dedent = '\xf03b';
    public static char Fa_delicious = '\xf1a5';
    public static char Fa_desktop = '\xf108';
    public static char Fa_deviantart = '\xf1bd';
    public static char Fa_diamond = '\xf219';
    public static char Fa_digg = '\xf1a6';
    public static char Fa_dollar = '\xf155';
    public static char Fa_dot_circle_o = '\xf192';
    public static char Fa_download = '\xf019';
    public static char Fa_dribbble = '\xf17d';
    public static char Fa_dropbox = '\xf16b';
    public static char Fa_drupal = '\xf1a9';
    public static char Fa_edge = '\xf282';
    public static char Fa_edit = '\xf044';
    public static char Fa_eject = '\xf052';
    public static char Fa_ellipsis_h = '\xf141';
    public static char Fa_ellipsis_v = '\xf142';
    public static char Fa_empire = '\xf1d1';
    public static char Fa_envelope = '\xf0e0';
    public static char Fa_envelope_o = '\xf003';
    public static char Fa_envelope_square = '\xf199';
    public static char Fa_eraser = '\xf12d';
    public static char Fa_eur = '\xf153';
    public static char Fa_euro = '\xf153';
    public static char Fa_exchange = '\xf0ec';
    public static char Fa_exclamation = '\xf12a';
    public static char Fa_exclamation_circle = '\xf06a';
    public static char Fa_exclamation_triangle = '\xf071';
    public static char Fa_expand = '\xf065';
    public static char Fa_expeditedssl = '\xf23e';
    public static char Fa_external_link = '\xf08e';
    public static char Fa_external_link_square = '\xf14c';
    public static char Fa_eye = '\xf06e';
    public static char Fa_eye_slash = '\xf070';
    public static char Fa_eyedropper = '\xf1fb';
    public static char Fa_facebook = '\xf09a';
    public static char Fa_facebook_f = '\xf09a';
    public static char Fa_facebook_official = '\xf230';
    public static char Fa_facebook_square = '\xf082';
    public static char Fa_fast_backward = '\xf049';
    public static char Fa_fast_forward = '\xf050';
    public static char Fa_fax = '\xf1ac';
    public static char Fa_feed = '\xf09e';
    public static char Fa_female = '\xf182';
    public static char Fa_fighter_jet = '\xf0fb';
    public static char Fa_file = '\xf15b';
    public static char Fa_file_archive_o = '\xf1c6';
    public static char Fa_file_audio_o = '\xf1c7';
    public static char Fa_file_code_o = '\xf1c9';
    public static char Fa_file_excel_o = '\xf1c3';
    public static char Fa_file_image_o = '\xf1c5';
    public static char Fa_file_movie_o = '\xf1c8';
    public static char Fa_file_o = '\xf016';
    public static char Fa_file_pdf_o = '\xf1c1';
    public static char Fa_file_photo_o = '\xf1c5';
    public static char Fa_file_picture_o = '\xf1c5';
    public static char Fa_file_powerpoint_o = '\xf1c4';
    public static char Fa_file_sound_o = '\xf1c7';
    public static char Fa_file_text = '\xf15c';
    public static char Fa_file_text_o = '\xf0f6';
    public static char Fa_file_video_o = '\xf1c8';
    public static char Fa_file_word_o = '\xf1c2';
    public static char Fa_file_zip_o = '\xf1c6';
    public static char Fa_files_o = '\xf0c5';
    public static char Fa_film = '\xf008';
    public static char Fa_filter = '\xf0b0';
    public static char Fa_fire = '\xf06d';
    public static char Fa_fire_extinguisher = '\xf134';
    public static char Fa_firefox = '\xf269';
    public static char Fa_flag = '\xf024';
    public static char Fa_flag_checkered = '\xf11e';
    public static char Fa_flag_o = '\xf11d';
    public static char Fa_flash = '\xf0e7';
    public static char Fa_flask = '\xf0c3';
    public static char Fa_flickr = '\xf16e';
    public static char Fa_floppy_o = '\xf0c7';
    public static char Fa_folder = '\xf07b';
    public static char Fa_folder_o = '\xf114';
    public static char Fa_folder_open = '\xf07c';
    public static char Fa_folder_open_o = '\xf115';
    public static char Fa_font = '\xf031';
    public static char Fa_fonticons = '\xf280';
    public static char Fa_fort_awesome = '\xf286';
    public static char Fa_forumbee = '\xf211';
    public static char Fa_forward = '\xf04e';
    public static char Fa_foursquare = '\xf180';
    public static char Fa_frown_o = '\xf119';
    public static char Fa_futbol_o = '\xf1e3';
    public static char Fa_gamepad = '\xf11b';
    public static char Fa_gavel = '\xf0e3';
    public static char Fa_gbp = '\xf154';
    public static char Fa_ge = '\xf1d1';
    public static char Fa_gear = '\xf013';
    public static char Fa_gears = '\xf085';
    public static char Fa_genderless = '\xf22d';
    public static char Fa_get_pocket = '\xf265';
    public static char Fa_gg = '\xf260';
    public static char Fa_gg_circle = '\xf261';
    public static char Fa_gift = '\xf06b';
    public static char Fa_git = '\xf1d3';
    public static char Fa_git_square = '\xf1d2';
    public static char Fa_github = '\xf09b';
    public static char Fa_github_alt = '\xf113';
    public static char Fa_github_square = '\xf092';
    public static char Fa_gittip = '\xf184';
    public static char Fa_glass = '\xf000';
    public static char Fa_globe = '\xf0ac';
    public static char Fa_google = '\xf1a0';
    public static char Fa_google_plus = '\xf0d5';
    public static char Fa_google_plus_square = '\xf0d4';
    public static char Fa_google_wallet = '\xf1ee';
    public static char Fa_graduation_cap = '\xf19d';
    public static char Fa_gratipay = '\xf184';
    public static char Fa_group = '\xf0c0';
    public static char Fa_h_square = '\xf0fd';
    public static char Fa_hacker_news = '\xf1d4';
    public static char Fa_hand_grab_o = '\xf255';
    public static char Fa_hand_lizard_o = '\xf258';
    public static char Fa_hand_o_down = '\xf0a7';
    public static char Fa_hand_o_left = '\xf0a5';
    public static char Fa_hand_o_right = '\xf0a4';
    public static char Fa_hand_o_up = '\xf0a6';
    public static char Fa_hand_paper_o = '\xf256';
    public static char Fa_hand_peace_o = '\xf25b';
    public static char Fa_hand_pointer_o = '\xf25a';
    public static char Fa_hand_rock_o = '\xf255';
    public static char Fa_hand_scissors_o = '\xf257';
    public static char Fa_hand_spock_o = '\xf259';
    public static char Fa_hand_stop_o = '\xf256';
    public static char Fa_hashtag = '\xf292';
    public static char Fa_hdd_o = '\xf0a0';
    public static char Fa_header = '\xf1dc';
    public static char Fa_headphones = '\xf025';
    public static char Fa_heart = '\xf004';
    public static char Fa_heart_o = '\xf08a';
    public static char Fa_heartbeat = '\xf21e';
    public static char Fa_history = '\xf1da';
    public static char Fa_home = '\xf015';
    public static char Fa_hospital_o = '\xf0f8';
    public static char Fa_hotel = '\xf236';
    public static char Fa_hourglass = '\xf254';
    public static char Fa_hourglass_1 = '\xf251';
    public static char Fa_hourglass_2 = '\xf252';
    public static char Fa_hourglass_3 = '\xf253';
    public static char Fa_hourglass_end = '\xf253';
    public static char Fa_hourglass_half = '\xf252';
    public static char Fa_hourglass_o = '\xf250';
    public static char Fa_hourglass_start = '\xf251';
    public static char Fa_houzz = '\xf27c';
    public static char Fa_html5 = '\xf13b';
    public static char Fa_i_cursor = '\xf246';
    public static char Fa_ils = '\xf20b';
    public static char Fa_image = '\xf03e';
    public static char Fa_inbox = '\xf01c';
    public static char Fa_indent = '\xf03c';
    public static char Fa_industry = '\xf275';
    public static char Fa_info = '\xf129';
    public static char Fa_info_circle = '\xf05a';
    public static char Fa_inr = '\xf156';
    public static char Fa_instagram = '\xf16d';
    public static char Fa_institution = '\xf19c';
    public static char Fa_internet_explorer = '\xf26b';
    public static char Fa_intersex = '\xf224';
    public static char Fa_ioxhost = '\xf208';
    public static char Fa_italic = '\xf033';
    public static char Fa_joomla = '\xf1aa';
    public static char Fa_jpy = '\xf157';
    public static char Fa_jsfiddle = '\xf1cc';
    public static char Fa_key = '\xf084';
    public static char Fa_keyboard_o = '\xf11c';
    public static char Fa_krw = '\xf159';
    public static char Fa_language = '\xf1ab';
    public static char Fa_laptop = '\xf109';
    public static char Fa_lastfm = '\xf202';
    public static char Fa_lastfm_square = '\xf203';
    public static char Fa_leaf = '\xf06c';
    public static char Fa_leanpub = '\xf212';
    public static char Fa_legal = '\xf0e3';
    public static char Fa_lemon_o = '\xf094';
    public static char Fa_level_down = '\xf149';
    public static char Fa_level_up = '\xf148';
    public static char Fa_life_bouy = '\xf1cd';
    public static char Fa_life_buoy = '\xf1cd';
    public static char Fa_life_ring = '\xf1cd';
    public static char Fa_life_saver = '\xf1cd';
    public static char Fa_lightbulb_o = '\xf0eb';
    public static char Fa_line_chart = '\xf201';
    public static char Fa_link = '\xf0c1';
    public static char Fa_linkedin = '\xf0e1';
    public static char Fa_linkedin_square = '\xf08c';
    public static char Fa_linux = '\xf17c';
    public static char Fa_list = '\xf03a';
    public static char Fa_list_alt = '\xf022';
    public static char Fa_list_ol = '\xf0cb';
    public static char Fa_list_ul = '\xf0ca';
    public static char Fa_location_arrow = '\xf124';
    public static char Fa_lock = '\xf023';
    public static char Fa_long_arrow_down = '\xf175';
    public static char Fa_long_arrow_left = '\xf177';
    public static char Fa_long_arrow_right = '\xf178';
    public static char Fa_long_arrow_up = '\xf176';
    public static char Fa_magic = '\xf0d0';
    public static char Fa_magnet = '\xf076';
    public static char Fa_mail_forward = '\xf064';
    public static char Fa_mail_reply = '\xf112';
    public static char Fa_mail_reply_all = '\xf122';
    public static char Fa_male = '\xf183';
    public static char Fa_map = '\xf279';
    public static char Fa_map_marker = '\xf041';
    public static char Fa_map_o = '\xf278';
    public static char Fa_map_pin = '\xf276';
    public static char Fa_map_signs = '\xf277';
    public static char Fa_mars = '\xf222';
    public static char Fa_mars_double = '\xf227';
    public static char Fa_mars_stroke = '\xf229';
    public static char Fa_mars_stroke_h = '\xf22b';
    public static char Fa_mars_stroke_v = '\xf22a';
    public static char Fa_maxcdn = '\xf136';
    public static char Fa_meanpath = '\xf20c';
    public static char Fa_medium = '\xf23a';
    public static char Fa_medkit = '\xf0fa';
    public static char Fa_meh_o = '\xf11a';
    public static char Fa_mercury = '\xf223';
    public static char Fa_microphone = '\xf130';
    public static char Fa_microphone_slash = '\xf131';
    public static char Fa_minus = '\xf068';
    public static char Fa_minus_circle = '\xf056';
    public static char Fa_minus_square = '\xf146';
    public static char Fa_minus_square_o = '\xf147';
    public static char Fa_mixcloud = '\xf289';
    public static char Fa_mobile = '\xf10b';
    public static char Fa_mobile_phone = '\xf10b';
    public static char Fa_modx = '\xf285';
    public static char Fa_money = '\xf0d6';
    public static char Fa_moon_o = '\xf186';
    public static char Fa_mortar_board = '\xf19d';
    public static char Fa_motorcycle = '\xf21c';
    public static char Fa_mouse_pointer = '\xf245';
    public static char Fa_music = '\xf001';
    public static char Fa_navicon = '\xf0c9';
    public static char Fa_neuter = '\xf22c';
    public static char Fa_newspaper_o = '\xf1ea';
    public static char Fa_object_group = '\xf247';
    public static char Fa_object_ungroup = '\xf248';
    public static char Fa_odnoklassniki = '\xf263';
    public static char Fa_odnoklassniki_square = '\xf264';
    public static char Fa_opencart = '\xf23d';
    public static char Fa_openid = '\xf19b';
    public static char Fa_opera = '\xf26a';
    public static char Fa_optin_monster = '\xf23c';
    public static char Fa_outdent = '\xf03b';
    public static char Fa_pagelines = '\xf18c';
    public static char Fa_paint_brush = '\xf1fc';
    public static char Fa_paper_plane = '\xf1d8';
    public static char Fa_paper_plane_o = '\xf1d9';
    public static char Fa_paperclip = '\xf0c6';
    public static char Fa_paragraph = '\xf1dd';
    public static char Fa_paste = '\xf0ea';
    public static char Fa_pause = '\xf04c';
    public static char Fa_pause_circle = '\xf28b';
    public static char Fa_pause_circle_o = '\xf28c';
    public static char Fa_paw = '\xf1b0';
    public static char Fa_paypal = '\xf1ed';
    public static char Fa_pencil = '\xf040';
    public static char Fa_pencil_square = '\xf14b';
    public static char Fa_pencil_square_o = '\xf044';
    public static char Fa_percent = '\xf295';
    public static char Fa_phone = '\xf095';
    public static char Fa_phone_square = '\xf098';
    public static char Fa_photo = '\xf03e';
    public static char Fa_picture_o = '\xf03e';
    public static char Fa_pie_chart = '\xf200';
    public static char Fa_pied_piper = '\xf1a7';
    public static char Fa_pied_piper_alt = '\xf1a8';
    public static char Fa_pinterest = '\xf0d2';
    public static char Fa_pinterest_p = '\xf231';
    public static char Fa_pinterest_square = '\xf0d3';
    public static char Fa_plane = '\xf072';
    public static char Fa_play = '\xf04b';
    public static char Fa_play_circle = '\xf144';
    public static char Fa_play_circle_o = '\xf01d';
    public static char Fa_plug = '\xf1e6';
    public static char Fa_plus = '\xf067';
    public static char Fa_plus_circle = '\xf055';
    public static char Fa_plus_square = '\xf0fe';
    public static char Fa_plus_square_o = '\xf196';
    public static char Fa_power_off = '\xf011';
    public static char Fa_print = '\xf02f';
    public static char Fa_product_hunt = '\xf288';
    public static char Fa_puzzle_piece = '\xf12e';
    public static char Fa_qq = '\xf1d6';
    public static char Fa_qrcode = '\xf029';
    public static char Fa_question = '\xf128';
    public static char Fa_question_circle = '\xf059';
    public static char Fa_quote_left = '\xf10d';
    public static char Fa_quote_right = '\xf10e';
    public static char Fa_ra = '\xf1d0';
    public static char Fa_random = '\xf074';
    public static char Fa_rebel = '\xf1d0';
    public static char Fa_recycle = '\xf1b8';
    public static char Fa_reddit = '\xf1a1';
    public static char Fa_reddit_alien = '\xf281';
    public static char Fa_reddit_square = '\xf1a2';
    public static char Fa_refresh = '\xf021';
    public static char Fa_registered = '\xf25d';
    public static char Fa_remove = '\xf00d';
    public static char Fa_renren = '\xf18b';
    public static char Fa_reorder = '\xf0c9';
    public static char Fa_repeat = '\xf01e';
    public static char Fa_reply = '\xf112';
    public static char Fa_reply_all = '\xf122';
    public static char Fa_retweet = '\xf079';
    public static char Fa_rmb = '\xf157';
    public static char Fa_road = '\xf018';
    public static char Fa_rocket = '\xf135';
    public static char Fa_rotate_left = '\xf0e2';
    public static char Fa_rotate_right = '\xf01e';
    public static char Fa_rouble = '\xf158';
    public static char Fa_rss = '\xf09e';
    public static char Fa_rss_square = '\xf143';
    public static char Fa_rub = '\xf158';
    public static char Fa_ruble = '\xf158';
    public static char Fa_rupee = '\xf156';
    public static char Fa_safari = '\xf267';
    public static char Fa_save = '\xf0c7';
    public static char Fa_scissors = '\xf0c4';
    public static char Fa_scribd = '\xf28a';
    public static char Fa_search = '\xf002';
    public static char Fa_search_minus = '\xf010';
    public static char Fa_search_plus = '\xf00e';
    public static char Fa_sellsy = '\xf213';
    public static char Fa_send = '\xf1d8';
    public static char Fa_send_o = '\xf1d9';
    public static char Fa_server = '\xf233';
    public static char Fa_share = '\xf064';
    public static char Fa_share_alt = '\xf1e0';
    public static char Fa_share_alt_square = '\xf1e1';
    public static char Fa_share_square = '\xf14d';
    public static char Fa_share_square_o = '\xf045';
    public static char Fa_shekel = '\xf20b';
    public static char Fa_sheqel = '\xf20b';
    public static char Fa_shield = '\xf132';
    public static char Fa_ship = '\xf21a';
    public static char Fa_shirtsinbulk = '\xf214';
    public static char Fa_shopping_bag = '\xf290';
    public static char Fa_shopping_basket = '\xf291';
    public static char Fa_shopping_cart = '\xf07a';
    public static char Fa_sign_in = '\xf090';
    public static char Fa_sign_out = '\xf08b';
    public static char Fa_signal = '\xf012';
    public static char Fa_simplybuilt = '\xf215';
    public static char Fa_sitemap = '\xf0e8';
    public static char Fa_skyatlas = '\xf216';
    public static char Fa_skype = '\xf17e';
    public static char Fa_slack = '\xf198';
    public static char Fa_sliders = '\xf1de';
    public static char Fa_slideshare = '\xf1e7';
    public static char Fa_smile_o = '\xf118';
    public static char Fa_soccer_ball_o = '\xf1e3';
    public static char Fa_sort = '\xf0dc';
    public static char Fa_sort_alpha_asc = '\xf15d';
    public static char Fa_sort_alpha_desc = '\xf15e';
    public static char Fa_sort_amount_asc = '\xf160';
    public static char Fa_sort_amount_desc = '\xf161';
    public static char Fa_sort_asc = '\xf0de';
    public static char Fa_sort_desc = '\xf0dd';
    public static char Fa_sort_down = '\xf0dd';
    public static char Fa_sort_numeric_asc = '\xf162';
    public static char Fa_sort_numeric_desc = '\xf163';
    public static char Fa_sort_up = '\xf0de';
    public static char Fa_soundcloud = '\xf1be';
    public static char Fa_space_shuttle = '\xf197';
    public static char Fa_spinner = '\xf110';
    public static char Fa_spoon = '\xf1b1';
    public static char Fa_spotify = '\xf1bc';
    public static char Fa_square = '\xf0c8';
    public static char Fa_square_o = '\xf096';
    public static char Fa_stack_exchange = '\xf18d';
    public static char Fa_stack_overflow = '\xf16c';
    public static char Fa_star = '\xf005';
    public static char Fa_star_half = '\xf089';
    public static char Fa_star_half_empty = '\xf123';
    public static char Fa_star_half_full = '\xf123';
    public static char Fa_star_half_o = '\xf123';
    public static char Fa_star_o = '\xf006';
    public static char Fa_steam = '\xf1b6';
    public static char Fa_steam_square = '\xf1b7';
    public static char Fa_step_backward = '\xf048';
    public static char Fa_step_forward = '\xf051';
    public static char Fa_stethoscope = '\xf0f1';
    public static char Fa_sticky_note = '\xf249';
    public static char Fa_sticky_note_o = '\xf24a';
    public static char Fa_stop = '\xf04d';
    public static char Fa_stop_circle = '\xf28d';
    public static char Fa_stop_circle_o = '\xf28e';
    public static char Fa_street_view = '\xf21d';
    public static char Fa_strikethrough = '\xf0cc';
    public static char Fa_stumbleupon = '\xf1a4';
    public static char Fa_stumbleupon_circle = '\xf1a3';
    public static char Fa_subscript = '\xf12c';
    public static char Fa_subway = '\xf239';
    public static char Fa_suitcase = '\xf0f2';
    public static char Fa_sun_o = '\xf185';
    public static char Fa_superscript = '\xf12b';
    public static char Fa_support = '\xf1cd';
    public static char Fa_table = '\xf0ce';
    public static char Fa_tablet = '\xf10a';
    public static char Fa_tachometer = '\xf0e4';
    public static char Fa_tag = '\xf02b';
    public static char Fa_tags = '\xf02c';
    public static char Fa_tasks = '\xf0ae';
    public static char Fa_taxi = '\xf1ba';
    public static char Fa_television = '\xf26c';
    public static char Fa_tencent_weibo = '\xf1d5';
    public static char Fa_terminal = '\xf120';
    public static char Fa_text_height = '\xf034';
    public static char Fa_text_width = '\xf035';
    public static char Fa_th = '\xf00a';
    public static char Fa_th_large = '\xf009';
    public static char Fa_th_list = '\xf00b';
    public static char Fa_thumb_tack = '\xf08d';
    public static char Fa_thumbs_down = '\xf165';
    public static char Fa_thumbs_o_down = '\xf088';
    public static char Fa_thumbs_o_up = '\xf087';
    public static char Fa_thumbs_up = '\xf164';
    public static char Fa_ticket = '\xf145';
    public static char Fa_times = '\xf00d';
    public static char Fa_times_circle = '\xf057';
    public static char Fa_times_circle_o = '\xf05c';
    public static char Fa_tint = '\xf043';
    public static char Fa_toggle_down = '\xf150';
    public static char Fa_toggle_left = '\xf191';
    public static char Fa_toggle_off = '\xf204';
    public static char Fa_toggle_on = '\xf205';
    public static char Fa_toggle_right = '\xf152';
    public static char Fa_toggle_up = '\xf151';
    public static char Fa_trademark = '\xf25c';
    public static char Fa_train = '\xf238';
    public static char Fa_transgender = '\xf224';
    public static char Fa_transgender_alt = '\xf225';
    public static char Fa_trash = '\xf1f8';
    public static char Fa_trash_o = '\xf014';
    public static char Fa_tree = '\xf1bb';
    public static char Fa_trello = '\xf181';
    public static char Fa_tripadvisor = '\xf262';
    public static char Fa_trophy = '\xf091';
    public static char Fa_truck = '\xf0d1';
    public static char Fa_try = '\xf195';
    public static char Fa_tty = '\xf1e4';
    public static char Fa_tumblr = '\xf173';
    public static char Fa_tumblr_square = '\xf174';
    public static char Fa_turkish_lira = '\xf195';
    public static char Fa_tv = '\xf26c';
    public static char Fa_twitch = '\xf1e8';
    public static char Fa_twitter = '\xf099';
    public static char Fa_twitter_square = '\xf081';
    public static char Fa_umbrella = '\xf0e9';
    public static char Fa_underline = '\xf0cd';
    public static char Fa_undo = '\xf0e2';
    public static char Fa_university = '\xf19c';
    public static char Fa_unlink = '\xf127';
    public static char Fa_unlock = '\xf09c';
    public static char Fa_unlock_alt = '\xf13e';
    public static char Fa_unsorted = '\xf0dc';
    public static char Fa_upload = '\xf093';
    public static char Fa_usb = '\xf287';
    public static char Fa_usd = '\xf155';
    public static char Fa_user = '\xf007';
    public static char Fa_user_md = '\xf0f0';
    public static char Fa_user_plus = '\xf234';
    public static char Fa_user_secret = '\xf21b';
    public static char Fa_user_times = '\xf235';
    public static char Fa_users = '\xf0c0';
    public static char Fa_venus = '\xf221';
    public static char Fa_venus_double = '\xf226';
    public static char Fa_venus_mars = '\xf228';
    public static char Fa_viacoin = '\xf237';
    public static char Fa_video_camera = '\xf03d';
    public static char Fa_vimeo = '\xf27d';
    public static char Fa_vimeo_square = '\xf194';
    public static char Fa_vine = '\xf1ca';
    public static char Fa_vk = '\xf189';
    public static char Fa_volume_down = '\xf027';
    public static char Fa_volume_off = '\xf026';
    public static char Fa_volume_up = '\xf028';
    public static char Fa_warning = '\xf071';
    public static char Fa_wechat = '\xf1d7';
    public static char Fa_weibo = '\xf18a';
    public static char Fa_weixin = '\xf1d7';
    public static char Fa_whatsapp = '\xf232';
    public static char Fa_wheelchair = '\xf193';
    public static char Fa_wifi = '\xf1eb';
    public static char Fa_wikipedia_w = '\xf266';
    public static char Fa_windows = '\xf17a';
    public static char Fa_won = '\xf159';
    public static char Fa_wordpress = '\xf19a';
    public static char Fa_wrench = '\xf0ad';
    public static char Fa_xing = '\xf168';
    public static char Fa_xing_square = '\xf169';
    public static char Fa_y_combinator = '\xf23b';
    public static char Fa_y_combinator_square = '\xf1d4';
    public static char Fa_yahoo = '\xf19e';
    public static char Fa_yc = '\xf23b';
    public static char Fa_yc_square = '\xf1d4';
    public static char Fa_yelp = '\xf1e9';
    public static char Fa_yen = '\xf157';
    public static char Fa_youtube = '\xf167';
    public static char Fa_youtube_play = '\xf16a';
    public static char Fa_youtube_square = '\xf166';
    #endregion

    public static FontFamily Family
    {
      get { return _family; }
    }
    public static Font Font
    {
      get { return _font; }
    }

    static FontAwesome()
    {
      var fonts = new PrivateFontCollection();
      var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("InnovatorAdmin.resources.fontawesome-webfont.ttf");
      var fontData = new byte[stream.Length];
      stream.Read(fontData, 0, (int)stream.Length);

      var fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
      Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
      uint dummy = 0;
      fonts.AddMemoryFont(fontPtr, fontData.Length);
      AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
      System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

      _family = fonts.Families[0];
      _font = new Font(_family, 16.0F);
    }
  }
}