using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoinsTest.Models
{
    //Object for CSV format
    public class RootCoinDetails
    {
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public object asset_platform_id { get; set; }

        [JsonProperty("platforms.")]
        public string Platforms { get; set; }
        public int block_time_in_minutes { get; set; }
        public string hashing_algorithm { get; set; }

        [JsonProperty("categories[0]")]
        public string Categories0 { get; set; }
        public object public_notice { get; set; }
        public List<object> additional_notices { get; set; }

        [JsonProperty("localization.en")]
        public string LocalizationEn { get; set; }

        [JsonProperty("localization.de")]
        public string LocalizationDe { get; set; }

        [JsonProperty("localization.es")]
        public string LocalizationEs { get; set; }

        [JsonProperty("localization.fr")]
        public string LocalizationFr { get; set; }

        [JsonProperty("localization.it")]
        public string LocalizationIt { get; set; }

        [JsonProperty("localization.pl")]
        public string LocalizationPl { get; set; }

        [JsonProperty("localization.ro")]
        public string LocalizationRo { get; set; }

        [JsonProperty("localization.hu")]
        public string LocalizationHu { get; set; }

        [JsonProperty("localization.nl")]
        public string LocalizationNl { get; set; }

        [JsonProperty("localization.pt")]
        public string LocalizationPt { get; set; }

        [JsonProperty("localization.sv")]
        public string LocalizationSv { get; set; }

        [JsonProperty("localization.vi")]
        public string LocalizationVi { get; set; }

        [JsonProperty("localization.tr")]
        public string LocalizationTr { get; set; }

        [JsonProperty("localization.ru")]
        public string LocalizationRu { get; set; }

        [JsonProperty("localization.ja")]
        public string LocalizationJa { get; set; }

        [JsonProperty("localization.zh")]
        public string LocalizationZh { get; set; }

        [JsonProperty("localization.zh-tw")]
        public string LocalizationZhTw { get; set; }

        [JsonProperty("localization.ko")]
        public string LocalizationKo { get; set; }

        [JsonProperty("localization.ar")]
        public string LocalizationAr { get; set; }

        [JsonProperty("localization.th")]
        public string LocalizationTh { get; set; }

        [JsonProperty("localization.id")]
        public string LocalizationId { get; set; }

        [JsonProperty("description.en")]
        public string DescriptionEn { get; set; }

        [JsonProperty("description.de")]
        public string DescriptionDe { get; set; }

        [JsonProperty("description.es")]
        public string DescriptionEs { get; set; }

        [JsonProperty("description.fr")]
        public string DescriptionFr { get; set; }

        [JsonProperty("description.it")]
        public string DescriptionIt { get; set; }

        [JsonProperty("description.pl")]
        public string DescriptionPl { get; set; }

        [JsonProperty("description.ro")]
        public string DescriptionRo { get; set; }

        [JsonProperty("description.hu")]
        public string DescriptionHu { get; set; }

        [JsonProperty("description.nl")]
        public string DescriptionNl { get; set; }

        [JsonProperty("description.pt")]
        public string DescriptionPt { get; set; }

        [JsonProperty("description.sv")]
        public string DescriptionSv { get; set; }

        [JsonProperty("description.vi")]
        public string DescriptionVi { get; set; }

        [JsonProperty("description.tr")]
        public string DescriptionTr { get; set; }

        [JsonProperty("description.ru")]
        public string DescriptionRu { get; set; }

        [JsonProperty("description.ja")]
        public string DescriptionJa { get; set; }

        [JsonProperty("description.zh")]
        public string DescriptionZh { get; set; }

        [JsonProperty("description.zh-tw")]
        public string DescriptionZhTw { get; set; }

        [JsonProperty("description.ko")]
        public string DescriptionKo { get; set; }

        [JsonProperty("description.ar")]
        public string DescriptionAr { get; set; }

        [JsonProperty("description.th")]
        public string DescriptionTh { get; set; }

        [JsonProperty("description.id")]
        public string DescriptionId { get; set; }

        [JsonProperty("links.homepage[0]")]
        public string LinksHomepage0 { get; set; }

        [JsonProperty("links.homepage[1]")]
        public string LinksHomepage1 { get; set; }

        [JsonProperty("links.homepage[2]")]
        public string LinksHomepage2 { get; set; }

        [JsonProperty("links.blockchain_site[0]")]
        public string LinksBlockchainSite0 { get; set; }

        [JsonProperty("links.blockchain_site[1]")]
        public string LinksBlockchainSite1 { get; set; }

        [JsonProperty("links.blockchain_site[2]")]
        public string LinksBlockchainSite2 { get; set; }

        [JsonProperty("links.blockchain_site[3]")]
        public string LinksBlockchainSite3 { get; set; }

        [JsonProperty("links.blockchain_site[4]")]
        public string LinksBlockchainSite4 { get; set; }

        [JsonProperty("links.official_forum_url[0]")]
        public string LinksOfficialForumUrl0 { get; set; }

        [JsonProperty("links.official_forum_url[1]")]
        public string LinksOfficialForumUrl1 { get; set; }

        [JsonProperty("links.official_forum_url[2]")]
        public string LinksOfficialForumUrl2 { get; set; }

        [JsonProperty("links.chat_url[0]")]
        public string LinksChatUrl0 { get; set; }

        [JsonProperty("links.chat_url[1]")]
        public string LinksChatUrl1 { get; set; }

        [JsonProperty("links.chat_url[2]")]
        public string LinksChatUrl2 { get; set; }

        [JsonProperty("links.announcement_url[0]")]
        public string LinksAnnouncementUrl0 { get; set; }

        [JsonProperty("links.announcement_url[1]")]
        public string LinksAnnouncementUrl1 { get; set; }

        [JsonProperty("links.twitter_screen_name")]
        public string LinksTwitterScreenName { get; set; }

        [JsonProperty("links.facebook_username")]
        public string LinksFacebookUsername { get; set; }

        [JsonProperty("links.bitcointalk_thread_identifier")]
        public int LinksBitcointalkThreadIdentifier { get; set; }

        [JsonProperty("links.telegram_channel_identifier")]
        public string LinksTelegramChannelIdentifier { get; set; }

        [JsonProperty("links.subreddit_url")]
        public string LinksSubredditUrl { get; set; }

        [JsonProperty("links.repos_url.github[0]")]
        public string LinksReposUrlGithub0 { get; set; }

        [JsonProperty("links.repos_url.bitbucket")]
        public List<object> LinksReposUrlBitbucket { get; set; }

        [JsonProperty("image.thumb")]
        public string ImageThumb { get; set; }

        [JsonProperty("image.small")]
        public string ImageSmall { get; set; }

        [JsonProperty("image.large")]
        public string ImageLarge { get; set; }
        public string country_origin { get; set; }
        public object genesis_date { get; set; }
        public object sentiment_votes_up_percentage { get; set; }
        public object sentiment_votes_down_percentage { get; set; }
        public int market_cap_rank { get; set; }
        public int coingecko_rank { get; set; }
        public double coingecko_score { get; set; }
        public double developer_score { get; set; }
        public double community_score { get; set; }
        public double liquidity_score { get; set; }
        public double public_interest_score { get; set; }

        [JsonProperty("public_interest_stats.alexa_rank")]
        public int PublicInterestStatsAlexaRank { get; set; }

        [JsonProperty("public_interest_stats.bing_matches")]
        public object PublicInterestStatsBingMatches { get; set; }
        public List<object> status_updates { get; set; }
        public DateTime last_updated { get; set; }
    }

    //Coin Details
    public class CoinDetails
    {
        public class Localization
        {
            public string en { get; set; }
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string it { get; set; }
            public string pl { get; set; }
            public string ro { get; set; }
            public string hu { get; set; }
            public string nl { get; set; }
            public string pt { get; set; }
            public string sv { get; set; }
            public string vi { get; set; }
            public string tr { get; set; }
            public string ru { get; set; }
            public string ja { get; set; }
            public string zh { get; set; }

            [JsonProperty("zh-tw")]
            public string ZhTw { get; set; }
            public string ko { get; set; }
            public string ar { get; set; }
            public string th { get; set; }
            public string id { get; set; }
        }

        public class Description
        {
            public string en { get; set; }
            public string de { get; set; }
            public string es { get; set; }
            public string fr { get; set; }
            public string it { get; set; }
            public string pl { get; set; }
            public string ro { get; set; }
            public string hu { get; set; }
            public string nl { get; set; }
            public string pt { get; set; }
            public string sv { get; set; }
            public string vi { get; set; }
            public string tr { get; set; }
            public string ru { get; set; }
            public string ja { get; set; }
            public string zh { get; set; }

            [JsonProperty("zh-tw")]
            public string ZhTw { get; set; }
            public string ko { get; set; }
            public string ar { get; set; }
            public string th { get; set; }
            public string id { get; set; }
        }

        public class ReposUrl
        {
            public List<string> github { get; set; }
            public List<object> bitbucket { get; set; }
        }

        public class Links
        {
            public List<string> homepage { get; set; }
            
        }

        public class Image
        {
            public string thumb { get; set; }
            public string small { get; set; }
            public string large { get; set; }
        }

        public class CurrentPrice
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class Ath
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class AthChangePercentage
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public int vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class AthDate
        {
            public DateTime aed { get; set; }
            public DateTime ars { get; set; }
            public DateTime aud { get; set; }
            public DateTime bch { get; set; }
            public DateTime bdt { get; set; }
            public DateTime bhd { get; set; }
            public DateTime bmd { get; set; }
            public DateTime bnb { get; set; }
            public DateTime brl { get; set; }
            public DateTime btc { get; set; }
            public DateTime cad { get; set; }
            public DateTime chf { get; set; }
            public DateTime clp { get; set; }
            public DateTime cny { get; set; }
            public DateTime czk { get; set; }
            public DateTime dkk { get; set; }
            public DateTime dot { get; set; }
            public DateTime eos { get; set; }
            public DateTime eth { get; set; }
            public DateTime eur { get; set; }
            public DateTime gbp { get; set; }
            public DateTime hkd { get; set; }
            public DateTime huf { get; set; }
            public DateTime idr { get; set; }
            public DateTime ils { get; set; }
            public DateTime inr { get; set; }
            public DateTime jpy { get; set; }
            public DateTime krw { get; set; }
            public DateTime kwd { get; set; }
            public DateTime lkr { get; set; }
            public DateTime ltc { get; set; }
            public DateTime mmk { get; set; }
            public DateTime mxn { get; set; }
            public DateTime myr { get; set; }
            public DateTime ngn { get; set; }
            public DateTime nok { get; set; }
            public DateTime nzd { get; set; }
            public DateTime php { get; set; }
            public DateTime pkr { get; set; }
            public DateTime pln { get; set; }
            public DateTime rub { get; set; }
            public DateTime sar { get; set; }
            public DateTime sek { get; set; }
            public DateTime sgd { get; set; }
            public DateTime thb { get; set; }
            public DateTime @try { get; set; }
            public DateTime twd { get; set; }
            public DateTime uah { get; set; }
            public DateTime usd { get; set; }
            public DateTime vef { get; set; }
            public DateTime vnd { get; set; }
            public DateTime xag { get; set; }
            public DateTime xau { get; set; }
            public DateTime xdr { get; set; }
            public DateTime xlm { get; set; }
            public DateTime xrp { get; set; }
            public DateTime yfi { get; set; }
            public DateTime zar { get; set; }
            public DateTime bits { get; set; }
            public DateTime link { get; set; }
            public DateTime sats { get; set; }
        }

        public class Atl
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class AtlChangePercentage
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class AtlDate
        {
            public DateTime aed { get; set; }
            public DateTime ars { get; set; }
            public DateTime aud { get; set; }
            public DateTime bch { get; set; }
            public DateTime bdt { get; set; }
            public DateTime bhd { get; set; }
            public DateTime bmd { get; set; }
            public DateTime bnb { get; set; }
            public DateTime brl { get; set; }
            public DateTime btc { get; set; }
            public DateTime cad { get; set; }
            public DateTime chf { get; set; }
            public DateTime clp { get; set; }
            public DateTime cny { get; set; }
            public DateTime czk { get; set; }
            public DateTime dkk { get; set; }
            public DateTime dot { get; set; }
            public DateTime eos { get; set; }
            public DateTime eth { get; set; }
            public DateTime eur { get; set; }
            public DateTime gbp { get; set; }
            public DateTime hkd { get; set; }
            public DateTime huf { get; set; }
            public DateTime idr { get; set; }
            public DateTime ils { get; set; }
            public DateTime inr { get; set; }
            public DateTime jpy { get; set; }
            public DateTime krw { get; set; }
            public DateTime kwd { get; set; }
            public DateTime lkr { get; set; }
            public DateTime ltc { get; set; }
            public DateTime mmk { get; set; }
            public DateTime mxn { get; set; }
            public DateTime myr { get; set; }
            public DateTime ngn { get; set; }
            public DateTime nok { get; set; }
            public DateTime nzd { get; set; }
            public DateTime php { get; set; }
            public DateTime pkr { get; set; }
            public DateTime pln { get; set; }
            public DateTime rub { get; set; }
            public DateTime sar { get; set; }
            public DateTime sek { get; set; }
            public DateTime sgd { get; set; }
            public DateTime thb { get; set; }
            public DateTime @try { get; set; }
            public DateTime twd { get; set; }
            public DateTime uah { get; set; }
            public DateTime usd { get; set; }
            public DateTime vef { get; set; }
            public DateTime vnd { get; set; }
            public DateTime xag { get; set; }
            public DateTime xau { get; set; }
            public DateTime xdr { get; set; }
            public DateTime xlm { get; set; }
            public DateTime xrp { get; set; }
            public DateTime yfi { get; set; }
            public DateTime zar { get; set; }
            public DateTime bits { get; set; }
            public DateTime link { get; set; }
            public DateTime sats { get; set; }
        }

        public class MarketCap
        {
            public int aed { get; set; }
            public int ars { get; set; }
            public int aud { get; set; }
            public double bch { get; set; }
            public int bdt { get; set; }
            public double bhd { get; set; }
            public int bmd { get; set; }
            public double bnb { get; set; }
            public int brl { get; set; }
            public double btc { get; set; }
            public int cad { get; set; }
            public int chf { get; set; }
            public int clp { get; set; }
            public int cny { get; set; }
            public int czk { get; set; }
            public int dkk { get; set; }
            public int dot { get; set; }
            public int eos { get; set; }
            public double eth { get; set; }
            public int eur { get; set; }
            public int gbp { get; set; }
            public int hkd { get; set; }
            public int huf { get; set; }
            public int idr { get; set; }
            public int ils { get; set; }
            public int inr { get; set; }
            public int jpy { get; set; }
            public int krw { get; set; }
            public double kwd { get; set; }
            public int lkr { get; set; }
            public double ltc { get; set; }
            public int mmk { get; set; }
            public int mxn { get; set; }
            public int myr { get; set; }
            public int ngn { get; set; }
            public int nok { get; set; }
            public int nzd { get; set; }
            public int php { get; set; }
            public int pkr { get; set; }
            public int pln { get; set; }
            public int rub { get; set; }
            public int sar { get; set; }
            public int sek { get; set; }
            public int sgd { get; set; }
            public int thb { get; set; }
            public int @try { get; set; }
            public int twd { get; set; }
            public int uah { get; set; }
            public int usd { get; set; }
            public double vef { get; set; }
            public int vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public int xdr { get; set; }
            public int xlm { get; set; }
            public int xrp { get; set; }
            public double yfi { get; set; }
            public int zar { get; set; }
            public int bits { get; set; }
            public int link { get; set; }
            public int sats { get; set; }
        }

        public class FullyDilutedValuation
        {
        }

        public class TotalVolume
        {
            public int aed { get; set; }
            public int ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public int bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public int brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public int clp { get; set; }
            public int cny { get; set; }
            public int czk { get; set; }
            public int dkk { get; set; }
            public double dot { get; set; }
            public int eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public int hkd { get; set; }
            public int huf { get; set; }
            public int idr { get; set; }
            public int ils { get; set; }
            public int inr { get; set; }
            public int jpy { get; set; }
            public int krw { get; set; }
            public double kwd { get; set; }
            public int lkr { get; set; }
            public double ltc { get; set; }
            public int mmk { get; set; }
            public int mxn { get; set; }
            public int myr { get; set; }
            public int ngn { get; set; }
            public int nok { get; set; }
            public int nzd { get; set; }
            public int php { get; set; }
            public int pkr { get; set; }
            public int pln { get; set; }
            public int rub { get; set; }
            public int sar { get; set; }
            public int sek { get; set; }
            public int sgd { get; set; }
            public int thb { get; set; }
            public int @try { get; set; }
            public int twd { get; set; }
            public int uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public int vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public int xlm { get; set; }
            public int xrp { get; set; }
            public double yfi { get; set; }
            public int zar { get; set; }
            public int bits { get; set; }
            public double link { get; set; }
            public int sats { get; set; }
        }

        public class High24h
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public int krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class Low24h
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChange24hInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage1hInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage24hInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage7dInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage14dInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage30dInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage60dInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage200dInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class PriceChangePercentage1yInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class MarketCapChange24hInCurrency
        {
            public double aed { get; set; }
            public int ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public int bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public int clp { get; set; }
            public double cny { get; set; }
            public int czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public int huf { get; set; }
            public int idr { get; set; }
            public double ils { get; set; }
            public int inr { get; set; }
            public int jpy { get; set; }
            public int krw { get; set; }
            public double kwd { get; set; }
            public int lkr { get; set; }
            public double ltc { get; set; }
            public int mmk { get; set; }
            public int mxn { get; set; }
            public double myr { get; set; }
            public int ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public int php { get; set; }
            public int pkr { get; set; }
            public double pln { get; set; }
            public int rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public int thb { get; set; }
            public double @try { get; set; }
            public int twd { get; set; }
            public int uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public int vnd { get; set; }
            public int xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public int xlm { get; set; }
            public int xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public int bits { get; set; }
            public double link { get; set; }
            public int sats { get; set; }
        }

        public class MarketCapChangePercentage24hInCurrency
        {
            public double aed { get; set; }
            public double ars { get; set; }
            public double aud { get; set; }
            public double bch { get; set; }
            public double bdt { get; set; }
            public double bhd { get; set; }
            public double bmd { get; set; }
            public double bnb { get; set; }
            public double brl { get; set; }
            public double btc { get; set; }
            public double cad { get; set; }
            public double chf { get; set; }
            public double clp { get; set; }
            public double cny { get; set; }
            public double czk { get; set; }
            public double dkk { get; set; }
            public double dot { get; set; }
            public double eos { get; set; }
            public double eth { get; set; }
            public double eur { get; set; }
            public double gbp { get; set; }
            public double hkd { get; set; }
            public double huf { get; set; }
            public double idr { get; set; }
            public double ils { get; set; }
            public double inr { get; set; }
            public double jpy { get; set; }
            public double krw { get; set; }
            public double kwd { get; set; }
            public double lkr { get; set; }
            public double ltc { get; set; }
            public double mmk { get; set; }
            public double mxn { get; set; }
            public double myr { get; set; }
            public double ngn { get; set; }
            public double nok { get; set; }
            public double nzd { get; set; }
            public double php { get; set; }
            public double pkr { get; set; }
            public double pln { get; set; }
            public double rub { get; set; }
            public double sar { get; set; }
            public double sek { get; set; }
            public double sgd { get; set; }
            public double thb { get; set; }
            public double @try { get; set; }
            public double twd { get; set; }
            public double uah { get; set; }
            public double usd { get; set; }
            public double vef { get; set; }
            public double vnd { get; set; }
            public double xag { get; set; }
            public double xau { get; set; }
            public double xdr { get; set; }
            public double xlm { get; set; }
            public double xrp { get; set; }
            public double yfi { get; set; }
            public double zar { get; set; }
            public double bits { get; set; }
            public double link { get; set; }
            public double sats { get; set; }
        }

        public class MarketData
        {
            public CurrentPrice current_price { get; set; }
            public object roi { get; set; }
            public Ath ath { get; set; }
            public AthChangePercentage ath_change_percentage { get; set; }
            public AthDate ath_date { get; set; }
            public Atl atl { get; set; }
            public AtlChangePercentage atl_change_percentage { get; set; }
            public AtlDate atl_date { get; set; }
            public MarketCap market_cap { get; set; }
            public int market_cap_rank { get; set; }
            public FullyDilutedValuation fully_diluted_valuation { get; set; }
            public TotalVolume total_volume { get; set; }
            public High24h high_24h { get; set; }
            public Low24h low_24h { get; set; }
            public double price_change_24h { get; set; }
            public double price_change_percentage_24h { get; set; }
            public double price_change_percentage_7d { get; set; }
            public double price_change_percentage_14d { get; set; }
            public double price_change_percentage_30d { get; set; }
            public double price_change_percentage_60d { get; set; }
            public double price_change_percentage_200d { get; set; }
            public double price_change_percentage_1y { get; set; }
            public double market_cap_change_24h { get; set; }
            public double market_cap_change_percentage_24h { get; set; }
            public PriceChange24hInCurrency price_change_24h_in_currency { get; set; }
            public PriceChangePercentage1hInCurrency price_change_percentage_1h_in_currency { get; set; }
            public PriceChangePercentage24hInCurrency price_change_percentage_24h_in_currency { get; set; }
            public PriceChangePercentage7dInCurrency price_change_percentage_7d_in_currency { get; set; }
            public PriceChangePercentage14dInCurrency price_change_percentage_14d_in_currency { get; set; }
            public PriceChangePercentage30dInCurrency price_change_percentage_30d_in_currency { get; set; }
            public PriceChangePercentage60dInCurrency price_change_percentage_60d_in_currency { get; set; }
            public PriceChangePercentage200dInCurrency price_change_percentage_200d_in_currency { get; set; }
            public PriceChangePercentage1yInCurrency price_change_percentage_1y_in_currency { get; set; }
            public MarketCapChange24hInCurrency market_cap_change_24h_in_currency { get; set; }
            public MarketCapChangePercentage24hInCurrency market_cap_change_percentage_24h_in_currency { get; set; }
            public int total_supply { get; set; }
            public object max_supply { get; set; }
            public double circulating_supply { get; set; }
            public DateTime last_updated { get; set; }
        }

        public class CommunityData
        {
            public object facebook_likes { get; set; }
            public int twitter_followers { get; set; }
            public int reddit_average_posts_48h { get; set; }
            public int reddit_average_comments_48h { get; set; }
            public int reddit_subscribers { get; set; }
            public int reddit_accounts_active_48h { get; set; }
            public int telegram_channel_user_count { get; set; }
        }

        public class CodeAdditionsDeletions4Weeks
        {
            public int additions { get; set; }
            public int deletions { get; set; }
        }

        public class DeveloperData
        {
            public int forks { get; set; }
            public int stars { get; set; }
            public int subscribers { get; set; }
            public int total_issues { get; set; }
            public int closed_issues { get; set; }
            public int pull_requests_merged { get; set; }
            public int pull_request_contributors { get; set; }
            public CodeAdditionsDeletions4Weeks code_additions_deletions_4_weeks { get; set; }
            public int commit_count_4_weeks { get; set; }
            public List<int> last_4_weeks_commit_activity_series { get; set; }
        }

        public class PublicInterestStats
        {
            public int alexa_rank { get; set; }
            public object bing_matches { get; set; }
        }

        public class Market
        {
            public string name { get; set; }
            public string identifier { get; set; }
            public bool has_trading_incentive { get; set; }
        }

        public class ConvertedLast
        {
            public double btc { get; set; }
            public double eth { get; set; }
            public double usd { get; set; }
        }

        public class ConvertedVolume
        {
            public double btc { get; set; }
            public double eth { get; set; }
            public double usd { get; set; }
        }

        public class Ticker
        {
            public string @base { get; set; }
            public string target { get; set; }
            public Market market { get; set; }
            public double last { get; set; }
            public double volume { get; set; }
            public ConvertedLast converted_last { get; set; }
            public ConvertedVolume converted_volume { get; set; }
            public string trust_score { get; set; }
            public double bid_ask_spread_percentage { get; set; }
            public DateTime timestamp { get; set; }
            public DateTime last_traded_at { get; set; }
            public DateTime last_fetch_at { get; set; }
            public bool is_anomaly { get; set; }
            public bool is_stale { get; set; }
            public string trade_url { get; set; }
            public object token_info_url { get; set; }
            public string coin_id { get; set; }
            public string target_coin_id { get; set; }
        }

        //Data to show in the coin details page
        public class RootElement
        {
            public string id { get; set; }
            public string symbol { get; set; }
            public string name { get; set; }
            
            public Links links { get; set; }
            public Image image { get; set; }
            
        }

        public class Platforms
        {
            public string platforms { get; set; }
        }
    }
 }

