﻿namespace PokemonGo.RocketAPI
{
    public static class Constants
    {
        // API stuff

        public const string ApiUrl = "https://pgorelease.nianticlabs.com/plfe/rpc";

        public const string VersionUrl = "https://pgorelease.nianticlabs.com/plfe/version";

        // Login stuff

        public const string LoginUrl = "https://sso.pokemon.com/sso/login?service=https%3A%2F%2Fsso.pokemon.com%2Fsso%2Foauth2.0%2FcallbackAuthorize";

        public const string LoginUserAgent = "pokemongo/0 CFNetwork/758.5.3 Darwin/15.6.0";
        public const string LoginOauthUrl = "https://sso.pokemon.com/sso/oauth2.0/accessToken";

        public const string GoogleAuthService = "audience:server:client_id:848232511240-7so421jotr2609rmqakceuu1luuq0ptb.apps.googleusercontent.com";

        public const string GoogleAuthApp = "com.nianticlabs.pokemongo";
        public const string GoogleAuthClientSig = "321187995bc7cdc2b5fc91b11a96e2baa8602c62";

    }
}