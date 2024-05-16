namespace Application.Common.Helpers
{
    public class ConstantVariables
    {
        public const string USERS_AND_BUSES_URL = "https://www.creativeems.com/cems/cemslocal/yiicems/index.php?r=api/Rest/infoKJ&agency_id=42ba67f1-ecbb-43c4-8b9a-afc172f062cc";
        public const string REGULAR_DOCTOR_MESSAGE = "Your patient {0} called EMS with the complaint of {1}. Hatzalah App";
        public const int DEFAULT_ACCEPTABLE_MEMBER_COUNT = 2;
        public const int DEFAULT_ACCEPTABLE_ALS_COUNT = 1;
        public const int DEFAULT_ACCEPTABLE_DRIVER_COUNT = 1;

        public const string API_KEY = "AIzaSyAfigW9w9IibqxDRFCamjefmnJBjUGJf9Y";
        public const string API_KEY_PEOPLE = "AIzaSyAfigW9w9IibqxDRFCamjefmnJBjUGJf9Y";
        public const string CLIENT_ID = "1002122645471-26mqmbvqo315f2qpuuhuo46e0cubk0a0.apps.googleusercontent.com";
        public const string CLIENT_SECRET = "N6XXQ_Ag_jyI0ALGVMgVeOOR";
        public const string TRAVEL_MODE = "DRIVING"; //Driving, Walking, Bicycling, Transit.
        public const string PLACE_PHOTO_URL = "https://maps.googleapis.com/maps/api/place/photo";

        public const string TOMTOM_API_KEY = "QERuyk4UeDcToJQOU9TU5u77BHUY3DbW";
        public static readonly string PdfOwnerPassword = "TR151219cx*!";
        public static readonly string Subject = "CJ Hatzolah Announcement";
        public static readonly string Body = "Announcement PDF file attached";
        public static readonly string FromEmail = "cjannouncements@hatzalah.live";
        public static readonly string FromName = "CJ Hatzolah";
        public static readonly string ReplyToEmail = "";
        

        public const string MAP_STREET_ADDRESS = "street_address";
        public const string MAP_ROUTE = "route";
        public const string MAP_COUNTRY = "country";
        public const string MAP_ADMINISTRATIVE_AREA_LEVEL_1 = "administrative_area_level_1";
        public const string MAP_ADMINISTRATIVE_AREA_LEVEL_2 = "administrative_area_level_2";
        public const string MAP_ADMINISTRATIVE_AREA_LEVEL_3 = "administrative_area_level_3";
        public const string MAP_ADMINISTRATIVE_AREA_LEVEL_4 = "administrative_area_level_4";
        public const string MAP_ADMINISTRATIVE_AREA_LEVEL_5 = "administrative_area_level_5";
        public const string MAP_CITY = "locality";
        public const string MAP_CITY2 = "sublocality";
        public const string MAP_NEIGHBORHOOD = "neighborhood";
        public const string MAP_FLOOR = "floor";
        public const string MAP_ROOM = "room";
        public const string MAP_STREET_NUMBER = "street_number";
        public const string MAP_ZIP = "postal_code";
        //public const string MAP_APT = "apt";
        public const string AGENCY_CHAT_URL = "https://generalapi.hatzalah.live/api/Agency";

        public const string MAP_DEFAULT_STATE = "New York";
        public const string MAP_DEFAULT_CITY = "Monsey";
        public const string MAP_DEFAULT_ZIP = "10952";

        public const string DEFAULT_CALL_LOCATION = MAP_DEFAULT_CITY + " " + MAP_DEFAULT_STATE + " " + MAP_DEFAULT_ZIP;
        public const string DEFAULT_CALL_LOCATION_FORMATTED_ADDRESS = "Monsey, NY 10952, USA";
        public const double DEFAULT_CALL_LOCATION_LATITUDE = 41.110985;
        public const double DEFAULT_CALL_LOCATION_LONGITUDE = -74.070698;

        public const int Mobile_User_Role_Id = 5;

        public const string EMS = "ems";
        public const string BLS = "bls";

        public const int SYS_ROLES_ADMIN_ID = 1;
        public const int SYS_ROLES_NS_COORDINATOR_ID = 10;

        public const int MAX_CLIENT_COUNT = 250;

        public const string MONSEY_NY_LAT_LONG = "41.110985, -74.070698";
        public const int RADIUS_SEARCH_AREA = 25000;

        public const int EFFECTIVE_UNTIL_TODAY = 1;
        public const int EFFECTIVE_UNTIL_TOMORROW = 2;
        public const string SELECTED_DAY_1 = "Today";
        public const string SELECTED_DAY_2 = "Tomorrow";



        public const string CALL_SYNC_TYPE_CREATED = "cad created";
        public const string CALL_SYNC_TYPE_UPDATED = "cad updated";
        public const string CALL_SYNC_TYPE_CREATED_ERROR = "The client could not be synchronized with the 3rd party. The create operation could not be performed in the 3rd party.";
        public const string CALL_SYNC_TYPE_UPDATED_ERROR = "The client could not be synchronized with the 3rd party. The update operation could not be performed in the 3rd party.";
        public const string CALL_SYNC_TYPE_AUTHORIZATION_ERROR = "Acces token does not match!";

        public const string CONTACT_SYSTEM_ADMIN = "Contact system administrator for further information.";

        public const string MESSAGE_TYPE_OUTBOUND = "Outbound";
        public const string MESSAGE_TYPE_INBOUND = "Inbound";
        public static string FOR_THE_SCENE_REPLY = "1";
        public static string FOR_THE_BUS_REPLY = "2";
        public static int TIMEOUT_SECONDS_FOR_MESSAGE_REPLY = 120;
        public static string NOTIFICATION_CALL_ALREADY_RECOVERED = "NOTIFICATION_CALL_ALREADY_RECOVERED";

        public static string NOTIFICATION_YOU_HAVE_BEEN_INACTIVATED = "NOTIFICATION_YOU_HAVE_BEEN_INACTIVATED";
        public static string NOTIFICATION_YOU_HAVE_BEEN_ACTIVATED = "NOTIFICATION_YOU_HAVE_BEEN_ACTIVATED";
        public static string NOTIFICATION_YOU_HAVE_BEEN_MUTED = "NOTIFICATION_YOU_HAVE_BEEN_MUTED";
        public static string NOTIFICATION_YOU_HAVE_BEEN_UNMUTED = "NOTIFICATION_YOU_HAVE_BEEN_UNMUTED";
        public static string MUTE_REPLY = "mute";
        public static string UNMUTE_REPLY = "unmute";
        public static string DISPATCHER_LOGGED_OUT_MESSAGE = "DISPATCHER_LOGGED_OUT_MESSAGE";
        public static string NOTIFICATION_YOU_HAVE_BEEN_SET_AS_UNITONCALL = "NOTIFICATION_YOU_HAVE_BEEN_SET_AS_UNITONCALL";
        public static string NOTIFICATION_YOU_HAVE_BEEN_SET_AS_MEDICONCALL = "NOTIFICATION_YOU_HAVE_BEEN_SET_AS_MEDICONCALL";
        public static string NOTIFICATION_YOU_HAVE_BEEN_REMOVED_FROM_CALL = "You have been removed from the call to";
        public static string NOTIFICATION_LOGGED_IN_AS_DISPATCHER = "You have been logged in as dispatcher";
        public static string NOTIFICATION_LOGGED_OUT_FROM_DISPATCHER = "You have been logged out, you are no longer dispatcher";
        public static string NOTIFICATION_CHANGED_LINE = "You have changed your line successfully. Your new line is: ";
        public static string NOTIFICATION_CALL_COVERED_FIRST_PART = "Thank you for all responders, the call to";
        public static string NOTIFICATION_CALL_COVERED_SECOND_PART = "is already covered";
        public static string NOTIFICATION_UPCOMING_SHIFT_SCHEDULE = "You have upcoming shift schedule for ";
        public static string NOTIFICATION_LINE_CHANGED = "Lines is now";

        public static string IS_BACKUP_PURPOSE = "IsBackup";
        public static string IS_DELAY_PURPOSE = "IsDelay";
        public static string IS_COORDINATOR_PURPOSE = "IsCoordinator";
        public static string MAIN_DISPATCHER_LOGIN = "Main Dispatcher Login";
        public static string CREATIVE_PBX = "Creative Phone";
        public static string DATAVANCED_PBX = "Datavanced Phone";
        public static string GET_PBX1_STATUS = @"https://pbx1.7831212.com/dispatch_login/cad_update.php?action=get_status";
        public static string GET_PBX2_STATUS = @"https://pbx2.7831212.com/dispatch_login/cad_update.php?action=get_status";
        public static string GET_CELL_PHONE_STATUS = "Cell Phone Status";
        public static string PBX_CONTROL = "PBX Control";

        public static string CALL_STATUS_UNATTENDED = "Unattended";
        public static string CALL_STATUS_ATTENDED = "Attended";
        public static string CALL_STATUS_MEMBERASSIGNED = "Member Assigned";
        public static string CALL_STATUS_ONSCENE = "On Scene";
        public static string CALL_STATUS_FROMSCENE = "From Scene";
        public static string CALL_STATUS_ALSTRANSPORT = "Als Transport";

        public static string MAPPED_CALL_STATUS_CALL_RECEIVED = "Call Received";
        public static string MAPPED_CALL_STATUS_COMMITTED = "Committed";
        public static string MAPPED_CALL_STATUS_UNITS_DISPATCHED = "Units Dispatched";
        public static string MAPPED_CALL_STATUS_MEDICS_DISPATCHED = "Medics Dispatched";
        public static string MAPPED_CALL_STATUS_BUS_DISPATCHED = "Bus Dispatched";
        public static string MAPPED_CALL_STATUS_ON_SCENE = "On Scene";
        public static string MAPPED_CALL_STATUS_BUS_BLS_TO_HOSPITAL = "Bus BLS to Hospital";
        public static string MAPPED_CALL_STATUS_BUS_ALS_TO_HOSPITAL = "Bus ALS to Hospital";
        public static string MAPPED_CALL_STATUS_OUT_AT_HOSPITAL = "Out at Hospital";
        public static string MAPPED_CALL_STATUS_BUS_AVAILABLE_AGAIN = "Bus Available Again";

        public const string MAIN_DISPATCHER_CHECK_AUTHORIZATION_URL = @"http://pbx2.dummyurl.com/dispatch_login/log.php?count=100";

        public static string SETTINGS_CREATIVE_OPTIONS = "Creative Options";
        public static string SETTINGS_DISPATCH_ALERT = "Dispatch Alert";
        public static string SETTINGS_MESSAGE_VALID_UNTIL = "Message Valid Until";
        public static string SETTINGS_MEMBERS_ON_CALL = "Members On Call";
        public static string SETTINGS_REDIRECT_TO_URL = "Redirect To Url";
        public static string SETTINGS_NOTIFICATIONS_GENERAL_STATUS = "Notifications General Status";
        public static string SETTINGS_NOTIFICATIONS_CALL_TEXT_STATUS = "Call Text Status";
        public static string SETTINGS_HOSTS = "Hosts";
        public static string SETTINGS_AUTO_DISMISS_CALL = "Auto Dismiss Call";
        public static string SETTINGS_AUTO_USE_THIS = "Auto Use This";
        public static string SETTINGS_NIGHT_CALL_TIME = "Night Call Time Settings";
        public static string SETTINGS_HOMEPAGE_FONT_SETTINGS = "Homepage Font Settings";
        public static string SETTINGS_OVERWRITE_ADDRESS = "Overwrite Address Popup";
        public static string SETTINGS_ALLOW_TO_TRANSFER_CALL = "Allow To Transfer Call";
        public static string SETTINGS_SUMMARY_QUOTA_SETTINGS = "Summary Quota Settings";
        public static string SETTINGS_COUNTY_CALLS = "County Calls";
        public static string SETTINGS_NOTIFICATION_POPUP_HOVER = "Enable Notification Popup Hover";
        public static string SETTINGS_FIRE_DISTRICT_POPUP = "Fire District Popup";
        public static string SETTINGS_CAN_LISTEN_TO_OPEN_PHONE_CALLS = "Can Listen To Open Phone Calls";
        public static string SETTINGS_CALCULATE_BUSES_PARKING_LOCATION = "Calculate Buses Parking Location";
        public static string SETTINGS_AUTO_CALL_STATUS = "Auto Call Status";
        public static string SETTINGS_DUPLICATE_PREVENTION_TIMEOUT = "Duplicate Prevention Timeout";
        public static string SETTINGS_SHOW_MAPVIEW_ON_RIGHT_SECTION = "Show Mapview Tab On Right Section";
        public static string SETTINGS_SHOW_ADDRESS_ON_MAPVIEW_TAB = "Show Address On Mapview Tab";
        public static string SETTINGS_HIGHLIGHT_ACTIVE_CLOSEST_BUS_ZONE = "Highlight Active Closest Bus Zone";
        public static string SETTINGS_AUTO_LOGOUT_IDLE_USERS_SETTINGS = "Auto Logout Idle Users Settings";

        public static string USER_SETTINGS_TURN_ON_BY_DEFAULT = "Turn On By Default";
        public static string USER_SETTINGS_THANK_YOU_MESSAGE_PERMISSION = "Thank You Message Permission";
        public static string USER_SETTINGS_ALERT_MESSAGE_PERMISSION = "Alert Message Permission";
        public static string USER_SETTINGS_ALERT_MESSAGE_PERMISSION_OPTION_PERMITTED = "Permitted";
        public static string USER_SETTINGS_ALERT_MESSAGE_PERMISSION_OPTION_NOT_PERMITTED = "Not permitted";

        public static string MESSAGE_TEXT_BACKUP_FIRE_CHEIF = "Any Fire Chief available to backup";
        public static string MESSAGE_TEXT_BACKUP_ALS = "Any ALS available to backup";
        public static string MESSAGE_TEXT_BACKUP_UNIT = "Any unit available to backup";
        public static string MESSAGE_TEXT_BACKUP_DRIVER = "Any driver available to backup";
        public static string SETTINGS_CLIENTINFO_FONT_SIZE = "Clientinfo FontSize";

        public static int EMERGENCY_TYPE_BLS = 1;
        public static int EMERGENCY_TYPE_ALS = 2;

        public static DateTime BUS_LOCATION_LAST_WORK_DATE = DateTime.Now;
        public static int BUS_LOCATION_TASK_COUNT = 0;

        public static string WARNING_NO_ADDRESS_FOUND = "No address found!";

        public static string CallAnswered = "Answered";
        public static string CallDeclined = "Declined";
        public static string CallHangup = "Hangup";

        public static string CreativeUrl = "https://www.creativeems.com/cems/cemslocal/yiicems/index.php?r=DispatchScreenExt/KJDispatching&agency_id=585bb44a-b2f8-11e4-8483-842b2b4bbc99";

        public static string WHATSAPP = "whatsapp";
        public static string TELEGRAM = "telegram";

        public static class GEONAMES
        {
            public const string USERNAME_PARAM = "&username=latifbahadir";
            public const string BASE_URL = "http://api.geonames.org/";
            public const string FIND_NEAR_BY_STREETS = "findNearbyStreetsJSON";
            public static string GET_PARAM_WITH_LAT_LNG(decimal lat, decimal lng) => $"lat={lat}&lng={lng}";
        }
        public static class STATUS_INFO_FIELDS
        {
            public static class STATUS_VALUES
            {
                public const string CANCELED = "Canceled";
                public const string COMPLETED = "Completed";
            }
            public static class TYPE_VALUES
            {
                public const string CANCELED = "Canceled Call";
                public const string DISMISSED = "Dispositions";
            }

            public static class INFO_TYPES_ENUMS
            {
                public const int CANCELED = 1;
                public const int COMPLETED = 2;
            }

            public static string GetInfoStatusStringById(int id)
            {
                if (id == INFO_TYPES_ENUMS.CANCELED)
                    return STATUS_VALUES.CANCELED;
                else if (id == INFO_TYPES_ENUMS.COMPLETED)
                    return STATUS_VALUES.COMPLETED;
                else
                    return "";
            }

            public static string GetInfoTypeStringById(int id)
            {
                if (id == INFO_TYPES_ENUMS.CANCELED)
                    return TYPE_VALUES.CANCELED;
                else if (id == INFO_TYPES_ENUMS.COMPLETED)
                    return TYPE_VALUES.DISMISSED;
                else
                    return "";
            }
        }
        public static class UserAuthorizations
        {
            public const string Dispatcher = "Dispatcher";
            public const string Monitor = "Monitor";
            public const string Backup = "Backup";
        }

        public static Dictionary<string, string> CallStatusMapping = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Call Received", "Unattended" },
            { "Units Dispatched", "Member Assigned" },
            { "Medics Dispatched", "Member Assigned" },
            { "Bus Dispatched", "Member Assigned" },
            { "On Scene", "On Scene" },
            { "Bus BLS to Hospital", "From Scene" },
            { "Bus ALS to Hospital", "Als Transport" },
            { "Out at Hospital", "From Scene" },
            { "Bus Available Again", "From Scene" }
        };

       

        public static string USER_SETTINGS_HIDE_EMPTY_SHIFTS_BUTTON_STATUS = "Hide Empty Shifts";

        public static string NEW_SQUARE = "New Square";
        public static string NEW_SQUARE_GUID_TEST = "26ddef0a-be59-4ac8-8bc0-8b8f1bafd498";
        public static string NEW_SQUARE_GUID_PRODUCTION = "15f933ab-68b4-4163-907c-01bf4a57adfb";

        public static class TRANSFER_CALL_FIELDS
        {
            public static class HATZALAH_TRANSFER_URLS
            {
                public const string KJ = "";
                public const string MONSEY = "https://hatzalahmonseyapi.datavanced.com/createTransferredCall";
                public const string MONTREAL = "";
                public const string LAKEWOOD = "https://lakewoodapi.hatzalah.live/createTransferredCall";
                public const string LINDEN = "";
            }

            public static class HATZALAH_ACKNOWLEDGE_URLS
            {
                public const string KJ = "";
                public const string MONSEY = "https://hatzalahmonseyapi.datavanced.com/callAcknowledgedByOtherHatzalah";
                public const string MONTREAL = "";
                public const string LAKEWOOD = "https://lakewoodapi.hatzalah.live/callAcknowledgedByOtherHatzalah";
                public const string LINDEN = "";
            }

            public static class HATZALAH_DESTINATIONS
            {
                public const string KJ = "Hatzalah KJ";
                public const string MONSEY = "Hatzalah Monsey";
                public const string MONTREAL = "Hatzalah Montreal";
                public const string LAKEWOOD = "Hatzalah Lakewood";
                public const string LINDEN = "Hatzalah Linden";
            }

            public static class HATZALAH_ENUMS
            {
                public const int KJ = 4;
                public const int MONSEY = 2;
                public const int MONTREAL = 3;
                public const int LAKEWOOD = 1;
                public const int LINDEN = 5;
            }

            public static string GetTransferUrlById(int id)
            {
                if (id == HATZALAH_ENUMS.KJ)
                    return HATZALAH_TRANSFER_URLS.KJ;
                else if (id == HATZALAH_ENUMS.MONSEY)
                    return HATZALAH_TRANSFER_URLS.MONSEY;
                else if (id == HATZALAH_ENUMS.MONTREAL)
                    return HATZALAH_TRANSFER_URLS.MONTREAL;
                else if (id == HATZALAH_ENUMS.LAKEWOOD)
                    return HATZALAH_TRANSFER_URLS.LAKEWOOD;
                else if (id == HATZALAH_ENUMS.LINDEN)
                    return HATZALAH_TRANSFER_URLS.LINDEN;
                else
                    return "";
            }

            public static string GetTransferDestinationById(int id)
            {
                if (id == HATZALAH_ENUMS.KJ)
                    return HATZALAH_DESTINATIONS.KJ;
                else if (id == HATZALAH_ENUMS.MONSEY)
                    return HATZALAH_DESTINATIONS.MONSEY;
                else if (id == HATZALAH_ENUMS.MONTREAL)
                    return HATZALAH_DESTINATIONS.MONTREAL;
                else if (id == HATZALAH_ENUMS.LAKEWOOD)
                    return HATZALAH_DESTINATIONS.LAKEWOOD;
                else if (id == HATZALAH_ENUMS.LINDEN)
                    return HATZALAH_DESTINATIONS.LINDEN;
                else
                    return "";
            }

            internal static string GetAcknowledgeUrlById(int? transferredFrom)
            {
                if (transferredFrom == HATZALAH_ENUMS.KJ)
                    return HATZALAH_TRANSFER_URLS.KJ;
                else if (transferredFrom == HATZALAH_ENUMS.MONSEY)
                    return HATZALAH_TRANSFER_URLS.MONSEY;
                else if (transferredFrom == HATZALAH_ENUMS.MONTREAL)
                    return HATZALAH_TRANSFER_URLS.MONTREAL;
                else if (transferredFrom == HATZALAH_ENUMS.LAKEWOOD)
                    return HATZALAH_TRANSFER_URLS.LAKEWOOD;
                else if (transferredFrom == HATZALAH_ENUMS.LINDEN)
                    return HATZALAH_TRANSFER_URLS.LINDEN;
                else
                    return "";
            }
        }
    }
}