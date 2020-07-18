namespace Faker.Types

open System
open Fable.Core

[<StringEnum>]
[<RequireQualifiedAccess>]
type FakeLocale =
    | [<CompiledName("az")>] Az
    | [<CompiledName("cz")>] Cz
    | [<CompiledName("de")>] De
    | [<CompiledName("de_AT")>] DeAt
    | [<CompiledName("de_CH")>] DeCh
    | [<CompiledName("en")>] En
    | [<CompiledName("en_AU")>] EnAu
    | [<CompiledName("en_BORK")>] EnBork
    | [<CompiledName("en_CA")>] EnCa
    | [<CompiledName("en_GB")>] EnGb
    | [<CompiledName("en_IE")>] EnIe
    | [<CompiledName("en_IND")>] EnInd
    | [<CompiledName("en_US")>] EnUs
    | [<CompiledName("en_au_ocker")>] EnAuOcker
    | [<CompiledName("es")>] Es
    | [<CompiledName("es_MX")>] EsMx
    | [<CompiledName("fa")>] Fa
    | [<CompiledName("fr")>] Fr
    | [<CompiledName("fr_CA")>] FrCa
    | [<CompiledName("ge")>] Ge
    | [<CompiledName("id_ID")>] IdId
    | [<CompiledName("it")>] It
    | [<CompiledName("ja")>] Ja
    | [<CompiledName("ko")>] Ko
    | [<CompiledName("nb_NO")>] NbNo
    | [<CompiledName("nep")>] Nep
    | [<CompiledName("nl")>] Nl
    | [<CompiledName("pl")>] Pl
    | [<CompiledName("pt_BR")>] PtBr
    | [<CompiledName("ru")>] Ru
    | [<CompiledName("sk")>] Sk
    | [<CompiledName("sv")>] Sv
    | [<CompiledName("tr")>] Tr
    | [<CompiledName("uk")>] Uk
    | [<CompiledName("vi")>] Yi
    | [<CompiledName("zh_CN")>] ZhCn
    | [<CompiledName("zh_TW")>] ZhTw

type IFakeAddress =
    abstract zipCode: unit -> string
    abstract zipCode: format:string -> string
    abstract city: unit -> string
    abstract cityPrefix: unit -> string
    abstract citySuffix: unit -> string
    abstract streetName: unit -> string
    abstract streetAddress: useFullAddress:bool -> string
    abstract streetSuffix: unit -> string
    abstract streetPrefix: unit -> string
    abstract secondaryAddress: unit -> string
    abstract county: unit -> string
    abstract country: unit -> string
    abstract countryCode: unit -> string
    abstract state: unit -> string
    abstract stateAbbr: unit -> string
    abstract latitude: unit -> string
    abstract longitude: unit -> string

type IFakeCommerce =
    abstract color: unit -> string
    abstract department: unit -> string
    abstract productName: unit -> string
    abstract price: min:int -> max:int -> dec:int -> symbol:char -> string
    abstract productAdjective: unit -> string
    abstract productMaterial: unit -> string
    abstract product: unit -> string

type IFakeCompany =
    abstract suffixes: unit -> string array
    abstract companyName: unit -> string
    abstract companySuffix: unit -> string
    abstract catchPhrase: unit -> string
    abstract bs: unit -> string
    abstract catchPhraseAdjective: unit -> string
    abstract catchPhraseDescriptor: unit -> string
    abstract catchPhraseNoun: unit -> string
    abstract bsAdjective: unit -> string
    abstract bsBuzz: unit -> string
    abstract bsNoun: unit -> string

type IFakeDatabase =
    abstract column: unit -> string
    abstract ``type``: unit -> string
    abstract collation: unit -> string
    abstract engine: unit -> string

type IFakeDate =
    abstract future: years:int -> refDate:DateTime -> DateTime option
    abstract between: fromDate:DateTime -> toDate:DateTime -> DateTime option
    abstract past: years:int -> refDate:DateTime -> DateTime option
    abstract recent: days:int -> DateTime option
    [<Emit("$0.month({ abbr: $1 })")>]
    abstract month: abbr: bool -> string
    abstract weekday: unit -> string

type IFakeFinance =
    abstract accountName: unit -> string
    abstract transactionType: unit -> string
    abstract currencyCode: unit -> string
    abstract currencyName: unit -> string
    abstract currencySymbol: unit -> string
    abstract bitcoinAddress: unit -> string
    abstract bic: unit -> string
    abstract account: length:int -> string
    abstract amount: min:int -> max:int -> dec:int -> symbol:char -> string
    abstract iban: formatted:bool -> string
    abstract mask: length:int -> parens:bool -> ellipsis:bool -> string

type IFakeHacker =
    abstract abbreviation: unit -> string
    abstract adjective: unit -> string
    abstract noun: unit -> string
    abstract verb: unit -> string
    abstract ingverb: unit -> string
    abstract phrase: unit -> string

type IFakeImage =
    abstract ``abstract``: width:int -> height:int -> randomize:bool -> string
    abstract animals: width:int -> height:int -> randomize:bool -> string
    abstract avatar: unit -> string
    abstract business: width:int -> height:int -> randomize:bool -> string
    abstract cats: width:int -> height:int -> randomize:bool -> string
    abstract city: width:int -> height:int -> randomize:bool -> string
    abstract dataUri: width:int -> height:int -> string
    abstract fashion: width:int -> height:int -> randomize:bool -> string
    abstract food: width:int -> height:int -> randomize:bool -> string
    abstract imageUrl: width:int -> height:int -> category:string -> randomize:bool -> https:bool -> string
    abstract nature: width:int -> height:int -> randomize:bool -> string
    abstract nightlife: width:int -> height:int -> randomize:bool -> string
    abstract people: width:int -> height:int -> randomize:bool -> string
    abstract sports: width:int -> height:int -> randomize:bool -> string
    abstract technics: width:int -> height:int -> randomize:bool -> string
    abstract image: width:int -> height:int -> randomize:bool -> string
    abstract transport: width:int -> height:int -> randomize:bool -> string

type IFakeName =
    abstract firstName: gender:int -> string
    abstract lastName: gender:int -> string
    abstract findName: firstName:string -> lastName:string -> gender:int -> string
    abstract prefix: gender:int -> string
    abstract suffix: unit -> string
    abstract title: unit -> string
    abstract jobDescriptor: unit -> string
    abstract jobTitle: unit -> string
    abstract jobArea: unit -> string
    abstract jobType: unit -> string

type IFakePhone =
    abstract phoneNumber: format:string -> string
    abstract phoneNumberFormat: phoneFormatsArrayIndex:int -> string
    abstract phoneFormats: unit -> string

type IFakeSystem =
    abstract fileName: ext:string -> fileType:string -> string
    abstract commonFileName: ext:string -> fileType:string -> string
    abstract mimeType: unit -> string
    abstract commonFileType: unit -> string
    abstract commonFileExt: fileType:string -> string
    abstract fileType: unit -> string
    abstract fileExt: mimeType:string -> string
    abstract directoryPath: unit -> string
    abstract filePath: unit -> string
    abstract semver: unit -> string

type IFakeLorem =
    abstract word: num:int -> string
    abstract words: num:int -> string
    abstract sentence: wordCount:int -> range:int -> string
    abstract slug: wordCount:int -> string
    abstract sentences: sentenceCount:int -> separator:string -> string
    abstract paragraph: sentenceCount:int -> string
    abstract paragraphs: paragraphCount:int -> separator:string -> string
    abstract text: times:int -> string
    abstract lines: lineCount:int -> string

type IFakeInternet =
    abstract avatar: unit -> string
    abstract email: firstName:string -> lastName:string -> provider:string -> string
    abstract exampleEmail: firstName:string -> lastName:string -> string
    abstract userName: firstName:string -> lastName:string -> string
    abstract protocol: unit -> string
    abstract url: unit -> string
    abstract domainName: unit -> string
    abstract domainSuffix: unit -> string
    abstract domainWord: unit -> string
    abstract ip: unit -> string
    abstract ipv6: unit -> string
    abstract userAgent: unit -> string
    abstract color: baseRed255:int -> baseGreen255:int -> baseBlue255:int -> string
    abstract mac: unit -> string
    abstract password: len:int -> memorable:bool -> pattern:string -> prefix:string -> string

type IBaseFaker =
    abstract fake: code:string -> string
    [<Emit("Object.keys($0.locales)")>]
    abstract locales: FakeLocale array
    abstract locale: FakeLocale
    abstract localeFallback: FakeLocale
    abstract address: IFakeAddress
    abstract commerce: IFakeCommerce
    abstract company: IFakeCompany
    abstract database: IFakeDatabase
    abstract date: IFakeDate
    abstract finance: IFakeFinance
    abstract hacker: IFakeHacker
    abstract image: IFakeImage
    abstract name: IFakeName
    abstract phone: IFakePhone
    abstract system: IFakeSystem
    abstract lorem: IFakeLorem
    abstract internet: IFakeInternet

type ISingleLocaleFaker =
    inherit IBaseFaker
    abstract locale: FakeLocale
    abstract localeFallback: FakeLocale

type IAllLocalesFaker =
    inherit IBaseFaker
    abstract locale: FakeLocale with get, set
    abstract localeFallback: FakeLocale with get, set
