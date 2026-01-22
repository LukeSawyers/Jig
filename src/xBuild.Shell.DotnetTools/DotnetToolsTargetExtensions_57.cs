using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T SamplesayLocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"samplesay_local {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkFileshare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.fileshare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Strans(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"strans {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GsuuonToolFnav(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gsuuon.tool.fnav {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Xbrlplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xbrlplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Safenetsign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"safenetsign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Textnotessearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"textnotessearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkRunmysql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.runmysql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nuggettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nuggettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkMergepdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.mergepdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hotreloadnuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hotreloadnuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GeosenseplusServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"geosenseplus.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GregXrmMcpFormengineer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"greg.xrm.mcp.formengineer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkHtmlutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.htmlutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T E3Sdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"e3.sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkYaml2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.yaml2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GsuuonToolStrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gsuuon.tool.strim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SpiderProjectinitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"spider.projectinitializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Wxxsayhello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wxxsayhello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkFilesize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.filesize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ResxporterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resxporter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WatchEventHubs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"watch-event-hubs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Envtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"envtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Icbt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"icbt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T NpgsqlGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"npgsql-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ToptenNuspectool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"topten.nuspectool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqltosharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqltosharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkEventtracker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.eventtracker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Metaprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"metaprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TestreporterReqnrollTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testreporter.reqnroll.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Restprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"restprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T GitlabsyncTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitlabsync.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Stupidlysimplenotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stupidlysimplenotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T StormancerNetproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"stormancer.netproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gisdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gisdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Propagate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"propagate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ItsystemsMsbuildextensions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"itsystems.msbuildextensions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Narwhal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"narwhal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SimplemigratorMigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"simplemigrator.migration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ssh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Releasenotesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"releasenotesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ObsidianMapperNunit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"obsidian-mapper-nunit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Editablemove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"editablemove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Mcpservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mcpservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lynxhub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lynxhub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RdappRdvs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rdapp.rdvs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gyan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gyan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T YuiMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"yui.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ssrt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ssrt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PranotSupermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pranot.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkNugetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.nugetversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sqliterest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sqliterest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Fwm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"fwm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rextestbotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rextestbotsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PillsgoodUnitytools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pillsgood.unitytools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkIgnoreremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.ignoreremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Termkeyvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"termkeyvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Testutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"testutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WachiSupermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wachi.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PeterpuffMarkdowntohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"peterpuff.markdowntohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T RazorlightPrecompile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"razorlight.precompile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkJsonimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.jsonimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sdh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sdh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Paketsequelmed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"paketsequelmed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Them(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"them {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Keyvaulter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"keyvaulter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Resxmergetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"resxmergetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OpenapiToMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"openapi-to-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sgd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sgd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ezversionupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ezversionupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Slnfixer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"slnfixer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Guidtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"guidtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkRunpostgres(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.runpostgres {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T X2j(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"x2j {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkGfquote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.gfquote {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KapelaSecurityEncryptionTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kapela.security.encryption.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScipExcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scip-excel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Shpytchuklab4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"shpytchuklab4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T KadderTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"kadder.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MintplayerVerz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"mintplayer.verz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MeziantouFilereferencer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"meziantou.filereferencer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Oxo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"oxo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Hellokoneko(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"hellokoneko {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WkThousand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wk.thousand {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Guid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PostgresqlTemporalTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"postgresql-temporal-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Githubhelpertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"githubhelpertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T TribitgroupMicroservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"tribitgroup.microservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pacquisition(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pacquisition {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Playlisttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"playlisttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Qmeratool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"qmeratool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T MaherMadwar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"maher.madwar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UploadGcloud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"upload-gcloud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ohadtoolfortest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ohadtoolfortest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Rdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Nunitreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"nunitreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XliffLocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xliff-localizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Sampleviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sampleviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}