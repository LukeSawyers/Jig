using System.Runtime.CompilerServices;
using CliWrap;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsShellExtensions
{
   extension(Shell shell)
   {
        public Command SamplesayLocal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"samplesay_local {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkFileshare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.fileshare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Strans(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"strans {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GsuuonToolFnav(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gsuuon.tool.fnav {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Xbrlplus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xbrlplus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Safenetsign(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"safenetsign {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Textnotessearch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"textnotessearch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkRunmysql(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.runmysql {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nuggettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nuggettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkMergepdf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.mergepdf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcl(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcl {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hotreloadnuget(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hotreloadnuget {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GeosenseplusServer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"geosenseplus.server {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GregXrmMcpFormengineer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"greg.xrm.mcp.formengineer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkHtmlutils(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.htmlutils {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command E3Sdk(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"e3.sdk {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkYaml2json(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.yaml2json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GsuuonToolStrim(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gsuuon.tool.strim {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SpiderProjectinitializer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"spider.projectinitializer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Wxxsayhello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wxxsayhello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkFilesize(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.filesize {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ResxporterTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resxporter.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WatchEventHubs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"watch-event-hubs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Envtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"envtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Icbt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"icbt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command NpgsqlGenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"npgsql-generator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ToptenNuspectool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"topten.nuspectool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqltosharp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqltosharp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkEventtracker(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.eventtracker {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Metaprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"metaprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TestreporterReqnrollTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testreporter.reqnroll.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Restprint(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"restprint {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkGuid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command GitlabsyncTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gitlabsync.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Stupidlysimplenotes(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stupidlysimplenotes {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command StormancerNetproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"stormancer.netproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gisdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gisdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Propagate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"propagate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ItsystemsMsbuildextensions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"itsystems.msbuildextensions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Narwhal(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"narwhal {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command SimplemigratorMigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"simplemigrator.migration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ssh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Releasenotesgenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"releasenotesgenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ObsidianMapperNunit(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"obsidian-mapper-nunit {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Editablemove(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"editablemove {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Mcpservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mcpservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Lynxhub(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"lynxhub {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RdappRdvs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rdapp.rdvs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Gyan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"gyan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command YuiMd5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"yui.md5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ssrt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ssrt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PranotSupermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pranot.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkNugetversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.nugetversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sqliterest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sqliterest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Fwm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"fwm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rextestbotsay(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rextestbotsay {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PillsgoodUnitytools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pillsgood.unitytools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkIgnoreremover(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.ignoreremover {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Termkeyvault(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"termkeyvault {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Testutil(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"testutil {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WachiSupermarket(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wachi.supermarket {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PeterpuffMarkdowntohtml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"peterpuff.markdowntohtml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command RazorlightPrecompile(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"razorlight.precompile {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkJsonimport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.jsonimport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sdh(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sdh {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Paketsequelmed(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"paketsequelmed {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Them(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"them {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Keyvaulter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"keyvaulter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Resxmergetool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"resxmergetool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command OpenapiToMcp(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"openapi-to-mcp {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sgd(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sgd {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ezversionupdate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ezversionupdate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Slnfixer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"slnfixer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Guidtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"guidtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkRunpostgres(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.runpostgres {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command X2j(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"x2j {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkGfquote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.gfquote {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KapelaSecurityEncryptionTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kapela.security.encryption.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command ScipExcel(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"scip-excel {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Shpytchuklab4(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"shpytchuklab4 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command KadderTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"kadder.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MintplayerVerz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"mintplayer.verz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MeziantouFilereferencer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"meziantou.filereferencer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Oxo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"oxo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Hellokoneko(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"hellokoneko {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command WkThousand(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"wk.thousand {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Guid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"guid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command PostgresqlTemporalTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"postgresql-temporal-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Githubhelpertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"githubhelpertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command TribitgroupMicroservice(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"tribitgroup.microservice {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Pacquisition(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"pacquisition {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Playlisttool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"playlisttool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Qmeratool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"qmeratool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command MaherMadwar(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"maher.madwar {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command UploadGcloud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"upload-gcloud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Ohadtoolfortest(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"ohadtoolfortest {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Rdeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"rdeploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Nunitreporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"nunitreporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command XliffLocalizer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"xliff-localizer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public Command Sampleviewer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => shell.DotnetToolCommand(
            FormattableStringFactory.Create($"sampleviewer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}