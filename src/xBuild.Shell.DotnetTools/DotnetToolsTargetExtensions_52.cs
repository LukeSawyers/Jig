using System.Runtime.CompilerServices;
using xBuild.Targets;

namespace xBuild.Shell.DotnetTools;

public static partial class DotnetToolsTargetExtensions
{
   extension<T>(T target) where T : ITarget
   {
        public T RocketuiDesignHost(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"rocketui.design.host {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSwitch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-switch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T XfuncDotnettool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"xfunc.dotnettool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docfxmarkdowngen(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docfxmarkdowngen {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDebuggerExtensions(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-debugger-extensions {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Docify(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"docify {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ScipDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"scip-dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Easydotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"easydotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Depsupdater(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"depsupdater {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dependencyupdatertool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependencyupdatertool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetI18nTranslate(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-i18n-translate {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dtdl2Validator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dtdl2-validator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Designdocmarkuplanguage(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"designdocmarkuplanguage {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DuotifyMarkdowntranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"duotify.markdowntranslator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRuntimeinfo(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-runtimeinfo {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dataexporter(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dataexporter {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Digger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"digger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetRename(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet.rename {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGimme(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gimme {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctopusOctoversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octopus.octoversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOutdatedNukeeper(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-outdated-nukeeper {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetWs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ws {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dllyaml(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dllyaml {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OperatorsharpToolsDotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"operatorsharp.tools.dotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNperf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nperf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGitstatus(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gitstatus {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetKorea(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-korea {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetstatic(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetstatic {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFwpf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-fwpf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowDebuggerFireflysrv(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.debugger.fireflysrv {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGf(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-gf {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetProjDiff(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-proj-diff {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dockervolumewatcher(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dockervolumewatcher {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T SfDataexport(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"sf-dataexport {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Lsifdotnet(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"lsifdotnet {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotdock(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotdock {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DevprimeTranslator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"devprime.translator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dnsnoop(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dnsnoop {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Ddc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ddc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNugetSources(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nuget-sources {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetVer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetToolRun(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tool-run {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnex(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnex {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DpaOpcuaRs(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dpa.opcua.rs {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T ProjectdiffTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"projectdiff.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Divoomtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"divoomtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Drw(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"drw {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTcloud(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tcloud {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T FtDatafangstTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ft.datafangst.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T WfmScriptdb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"wfm.scriptdb {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dydoc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dydoc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Gitdateversion(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"gitdateversion {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Thirdlicense(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"thirdlicense {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetF5(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-f5 {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetversionpatch(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetversionpatch {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHello(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-hello {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMystique(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-mystique {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T PhoesionGlowDeployer(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"phoesion.glow.deployer {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dotnetdacmigration(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnetdacmigration {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T LadeakGrpcproxy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"ladeak.grpcproxy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deps2mermaid(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deps2mermaid {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetReleaseNote(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-release-note {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetFindReplace(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-find-replace {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetUps(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-ups {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DimonsmartLocalollamamcpserver(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dimonsmart.localollamamcpserver {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetOnnx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-onnx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DworthenTaskrunner(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dworthen.taskrunner {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetKey(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-key {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Pgscan(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"pgscan {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbvm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbvm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dumpe(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dumpe {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dcu(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dcu {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dviz(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dviz {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DiscordNetToolsLocalizationResx(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"discord.net.tools.localization.resx {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DependabotPrManager(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dependabot-pr-manager {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetNrm(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-nrm {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetHandle(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-handle {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetZipSource(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-zip-source {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dummylogger(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dummylogger {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T EmergingDb(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"emerging-db {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dispatchergenerator(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dispatchergenerator {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T OctoversionTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"octoversion.tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetTidy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-tidy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotsefSln(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotsef-sln {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JacdacDevtools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jacdac.devtools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetListProcess(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-list-process {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSdt(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-sdt {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DiscordNetToolsLocalizationJson(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"discord.net.tools.localization.json {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T JjconsultingDeploy(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"jjconsulting.deploy {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Deepren(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"deepren {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetSlugentExampletool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-slugent-exampletool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T Dbtool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbtool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPacman(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-pacman {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetPrepare(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-prepare {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetGitTool(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-git-tool {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DbexpressionTools(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dbexpression.tools {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetMessageValidation(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-message-validation {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T DotnetImooc(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"dotnet-imooc {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );

        public T UpdevsSdkGenerators(
            FormattableString arguments,
            ShellLoggingOptions? loggingOptions = null
        ) => target.ExecutesDotNetTool(
            FormattableStringFactory.Create($"updevs.sdk.generators {arguments.Format}", arguments.GetArguments()),
            loggingOptions
        );
    }
}