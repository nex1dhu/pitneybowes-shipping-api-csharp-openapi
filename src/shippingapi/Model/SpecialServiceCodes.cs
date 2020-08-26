/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = shippingapi.Client.OpenAPIDateConverter;

namespace shippingapi.Model
{
    /// <summary>
    /// * Ins - Insured Mail.  * RR - Return receipt.  * Sig - Item is trackable if special service is requested. * ADSIG - Adult signature required. * Cert - Certified mail. * DelCon - Delivery confirmation. * ERR - Electronic return receipt. * RRm - Return receipt for merchandise. * Reg - Registered mail. * RegIns - Registered mail with insurance. * SH - Special handling - fragile. * CertRD - Certified mail with restricted delivery. * COD - Collect on delivery. * CODRD - Collect on delivery with restricted delivery. * InsRD - Insurance with restricted delivery. * RegRD - Registered mail with restricted delivery. * RegCOD - Registered mail with COD. * SigRD - Signature required with restricted delivery. * ADSIGRD - Adult signature required with restricted delivery. * RegInsRD - Registered mail with insurance and restricted delivery. * CERTAD - Certified mail with adult signature. * CERTADRD - Certified mail with adult signature and restricted delivery. * hazmat - Hazardous materials. * liveanimal - Live animal surcharge. * liveanimal_poultry - Live Animal-Day Old Poultry Surcharge * holiday - Holiday Delivery- For Priority Mail Express Service Only * sunday - Sunday delivery. * sunday_holiday - Sunday and holiday delivery. * PO_to_Addressee - PO to addressee * noWeekend - Do not deliver on weekend * TenThirty - Delivery by 10:30 AM * PMOD_OPTIONS - PMOD options * NOTIFICATIONS - Notifications. 
    /// </summary>
    /// <value>* Ins - Insured Mail.  * RR - Return receipt.  * Sig - Item is trackable if special service is requested. * ADSIG - Adult signature required. * Cert - Certified mail. * DelCon - Delivery confirmation. * ERR - Electronic return receipt. * RRm - Return receipt for merchandise. * Reg - Registered mail. * RegIns - Registered mail with insurance. * SH - Special handling - fragile. * CertRD - Certified mail with restricted delivery. * COD - Collect on delivery. * CODRD - Collect on delivery with restricted delivery. * InsRD - Insurance with restricted delivery. * RegRD - Registered mail with restricted delivery. * RegCOD - Registered mail with COD. * SigRD - Signature required with restricted delivery. * ADSIGRD - Adult signature required with restricted delivery. * RegInsRD - Registered mail with insurance and restricted delivery. * CERTAD - Certified mail with adult signature. * CERTADRD - Certified mail with adult signature and restricted delivery. * hazmat - Hazardous materials. * liveanimal - Live animal surcharge. * liveanimal_poultry - Live Animal-Day Old Poultry Surcharge * holiday - Holiday Delivery- For Priority Mail Express Service Only * sunday - Sunday delivery. * sunday_holiday - Sunday and holiday delivery. * PO_to_Addressee - PO to addressee * noWeekend - Do not deliver on weekend * TenThirty - Delivery by 10:30 AM * PMOD_OPTIONS - PMOD options * NOTIFICATIONS - Notifications. </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SpecialServiceCodes
    {
        /// <summary>
        /// Enum ADSIG for value: ADSIG
        /// </summary>
        [EnumMember(Value = "ADSIG")]
        ADSIG = 1,

        /// <summary>
        /// Enum ADSIGRD for value: ADSIGRD
        /// </summary>
        [EnumMember(Value = "ADSIGRD")]
        ADSIGRD = 2,

        /// <summary>
        /// Enum Cert for value: Cert
        /// </summary>
        [EnumMember(Value = "Cert")]
        Cert = 3,

        /// <summary>
        /// Enum CERTAD for value: CERTAD
        /// </summary>
        [EnumMember(Value = "CERTAD")]
        CERTAD = 4,

        /// <summary>
        /// Enum CERTADRD for value: CERTADRD
        /// </summary>
        [EnumMember(Value = "CERTADRD")]
        CERTADRD = 5,

        /// <summary>
        /// Enum CertRD for value: CertRD
        /// </summary>
        [EnumMember(Value = "CertRD")]
        CertRD = 6,

        /// <summary>
        /// Enum COD for value: COD
        /// </summary>
        [EnumMember(Value = "COD")]
        COD = 7,

        /// <summary>
        /// Enum CODRD for value: CODRD
        /// </summary>
        [EnumMember(Value = "CODRD")]
        CODRD = 8,

        /// <summary>
        /// Enum DelCon for value: DelCon
        /// </summary>
        [EnumMember(Value = "DelCon")]
        DelCon = 9,

        /// <summary>
        /// Enum ERR for value: ERR
        /// </summary>
        [EnumMember(Value = "ERR")]
        ERR = 10,

        /// <summary>
        /// Enum Hazmat for value: hazmat
        /// </summary>
        [EnumMember(Value = "hazmat")]
        Hazmat = 11,

        /// <summary>
        /// Enum Holiday for value: holiday
        /// </summary>
        [EnumMember(Value = "holiday")]
        Holiday = 12,

        /// <summary>
        /// Enum InsRD for value: InsRD
        /// </summary>
        [EnumMember(Value = "InsRD")]
        InsRD = 13,

        /// <summary>
        /// Enum Liveanimal for value: liveanimal
        /// </summary>
        [EnumMember(Value = "liveanimal")]
        Liveanimal = 14,

        /// <summary>
        /// Enum Liveanimalpoultry for value: liveanimal - poultry
        /// </summary>
        [EnumMember(Value = "liveanimal - poultry")]
        Liveanimalpoultry = 15,

        /// <summary>
        /// Enum PMODOPTIONS for value: PMOD_OPTIONS
        /// </summary>
        [EnumMember(Value = "PMOD_OPTIONS")]
        PMODOPTIONS = 16,

        /// <summary>
        /// Enum Reg for value: Reg
        /// </summary>
        [EnumMember(Value = "Reg")]
        Reg = 17,

        /// <summary>
        /// Enum RegCOD for value: RegCOD
        /// </summary>
        [EnumMember(Value = "RegCOD")]
        RegCOD = 18,

        /// <summary>
        /// Enum RegIns for value: RegIns
        /// </summary>
        [EnumMember(Value = "RegIns")]
        RegIns = 19,

        /// <summary>
        /// Enum RegInsRD for value: RegInsRD
        /// </summary>
        [EnumMember(Value = "RegInsRD")]
        RegInsRD = 20,

        /// <summary>
        /// Enum RegRD for value: RegRD
        /// </summary>
        [EnumMember(Value = "RegRD")]
        RegRD = 21,

        /// <summary>
        /// Enum RR for value: RR
        /// </summary>
        [EnumMember(Value = "RR")]
        RR = 22,

        /// <summary>
        /// Enum RRM for value: RRM
        /// </summary>
        [EnumMember(Value = "RRM")]
        RRM = 23,

        /// <summary>
        /// Enum SH for value: SH
        /// </summary>
        [EnumMember(Value = "SH")]
        SH = 24,

        /// <summary>
        /// Enum SIG for value: SIG
        /// </summary>
        [EnumMember(Value = "SIG")]
        SIG = 25,

        /// <summary>
        /// Enum SigRD for value: SigRD
        /// </summary>
        [EnumMember(Value = "SigRD")]
        SigRD = 26,

        /// <summary>
        /// Enum Sunday for value: sunday
        /// </summary>
        [EnumMember(Value = "sunday")]
        Sunday = 27,

        /// <summary>
        /// Enum Sundayholiday for value: sunday - holiday
        /// </summary>
        [EnumMember(Value = "sunday - holiday")]
        Sundayholiday = 28,

        /// <summary>
        /// Enum NOTIFICATIONS for value: NOTIFICATIONS
        /// </summary>
        [EnumMember(Value = "NOTIFICATIONS")]
        NOTIFICATIONS = 29,

        /// <summary>
        /// Enum PBXPS for value: PBXPS
        /// </summary>
        [EnumMember(Value = "PBXPS")]
        PBXPS = 30,

        /// <summary>
        /// Enum PBXUS for value: PBXUS
        /// </summary>
        [EnumMember(Value = "PBXUS")]
        PBXUS = 31,

        /// <summary>
        /// Enum PBXPE for value: PBXPE
        /// </summary>
        [EnumMember(Value = "PBXPE")]
        PBXPE = 32,

        /// <summary>
        /// Enum ANCILLARYENDORSEMENT for value: ANCILLARY_ENDORSEMENT
        /// </summary>
        [EnumMember(Value = "ANCILLARY_ENDORSEMENT")]
        ANCILLARYENDORSEMENT = 33,

        /// <summary>
        /// Enum ADDHDL for value: ADD_HDL
        /// </summary>
        [EnumMember(Value = "ADD_HDL")]
        ADDHDL = 34,

        /// <summary>
        /// Enum ALCOHOL for value: ALCOHOL
        /// </summary>
        [EnumMember(Value = "ALCOHOL")]
        ALCOHOL = 35,

        /// <summary>
        /// Enum CARRIERLEAVEIFNORES for value: CARRIER_LEAVE_IF_NO_RES
        /// </summary>
        [EnumMember(Value = "CARRIER_LEAVE_IF_NO_RES")]
        CARRIERLEAVEIFNORES = 36,

        /// <summary>
        /// Enum DIRECTSIG for value: DIRECT_SIG
        /// </summary>
        [EnumMember(Value = "DIRECT_SIG")]
        DIRECTSIG = 37,

        /// <summary>
        /// Enum APPOINTMENT for value: APPOINTMENT
        /// </summary>
        [EnumMember(Value = "APPOINTMENT")]
        APPOINTMENT = 38,

        /// <summary>
        /// Enum DATE for value: DATE
        /// </summary>
        [EnumMember(Value = "DATE")]
        DATE = 39,

        /// <summary>
        /// Enum EVENING for value: EVENING
        /// </summary>
        [EnumMember(Value = "EVENING")]
        EVENING = 40,

        /// <summary>
        /// Enum GCOD for value: GCOD
        /// </summary>
        [EnumMember(Value = "GCOD")]
        GCOD = 41,

        /// <summary>
        /// Enum PAL for value: PAL
        /// </summary>
        [EnumMember(Value = "PAL")]
        PAL = 42,

        /// <summary>
        /// Enum PALPLUS for value: PAL_PLUS
        /// </summary>
        [EnumMember(Value = "PAL_PLUS")]
        PALPLUS = 43,

        /// <summary>
        /// Enum SATDELIVERY for value: SAT_DELIVERY
        /// </summary>
        [EnumMember(Value = "SAT_DELIVERY")]
        SATDELIVERY = 44,

        /// <summary>
        /// Enum SATPICKUP for value: SAT_PICKUP
        /// </summary>
        [EnumMember(Value = "SAT_PICKUP")]
        SATPICKUP = 45,

        /// <summary>
        /// Enum HOLD for value: HOLD
        /// </summary>
        [EnumMember(Value = "HOLD")]
        HOLD = 46,

        /// <summary>
        /// Enum NOSIG for value: NO_SIG
        /// </summary>
        [EnumMember(Value = "NO_SIG")]
        NOSIG = 47,

        /// <summary>
        /// Enum PRL for value: PRL
        /// </summary>
        [EnumMember(Value = "PRL")]
        PRL = 48,

        /// <summary>
        /// Enum ADULTSIG for value: ADULT_SIG
        /// </summary>
        [EnumMember(Value = "ADULT_SIG")]
        ADULTSIG = 49,

        /// <summary>
        /// Enum CARBON for value: CARBON
        /// </summary>
        [EnumMember(Value = "CARBON")]
        CARBON = 50,

        /// <summary>
        /// Enum CODCASHIER for value: COD_CASHIER
        /// </summary>
        [EnumMember(Value = "COD_CASHIER")]
        CODCASHIER = 51,

        /// <summary>
        /// Enum CODCHECK for value: COD_CHECK
        /// </summary>
        [EnumMember(Value = "COD_CHECK")]
        CODCHECK = 52,

        /// <summary>
        /// Enum DELCON for value: DEL_CON
        /// </summary>
        [EnumMember(Value = "DEL_CON")]
        DELCON = 53,

        /// <summary>
        /// Enum DIRECT for value: DIRECT
        /// </summary>
        [EnumMember(Value = "DIRECT")]
        DIRECT = 54,

        /// <summary>
        /// Enum DRYICE for value: DRY_ICE
        /// </summary>
        [EnumMember(Value = "DRY_ICE")]
        DRYICE = 55,

        /// <summary>
        /// Enum INS for value: INS
        /// </summary>
        [EnumMember(Value = "INS")]
        INS = 56,

        /// <summary>
        /// Enum SHPRELEASE for value: SHP_RELEASE
        /// </summary>
        [EnumMember(Value = "SHP_RELEASE")]
        SHPRELEASE = 57,

        /// <summary>
        /// Enum VERBAL for value: VERBAL
        /// </summary>
        [EnumMember(Value = "VERBAL")]
        VERBAL = 58

    }

}
