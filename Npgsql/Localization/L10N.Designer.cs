﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Npgsql.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class L10N {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal L10N() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Npgsql.Localization.L10N", typeof(L10N).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ApplicationName.
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ApplicationName.
        /// </summary>
        internal static string ApplicationNameDescription {
            get {
                return ResourceManager.GetString("ApplicationNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only AuthenticationClearTextPassword and AuthenticationMD5Password supported for now. Received: {0}.
        /// </summary>
        internal static string AuthenticationMethodNotSupported {
            get {
                return ResourceManager.GetString("AuthenticationMethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There have been errors reported by the backend..
        /// </summary>
        internal static string BackendErrors {
            get {
                return ResourceManager.GetString("BackendErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be empty.
        /// </summary>
        internal static string CannotBeEmpty {
            get {
                return ResourceManager.GetString("CannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in Close().
        /// </summary>
        internal static string CloseError {
            get {
                return ResourceManager.GetString("CloseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CommandTimeout.
        /// </summary>
        internal static string CommandTimeout {
            get {
                return ResourceManager.GetString("CommandTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CommandTimeout.
        /// </summary>
        internal static string CommandTimeoutDescription {
            get {
                return ResourceManager.GetString("CommandTimeoutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CommandTimeout can&apos;t be less than zero..
        /// </summary>
        internal static string CommandTimeoutLessZero {
            get {
                return ResourceManager.GetString("CommandTimeoutLessZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only Text and StoredProcedure types supported!.
        /// </summary>
        internal static string CommandTypeTableDirect {
            get {
                return ResourceManager.GetString("CommandTypeTableDirect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Npgsql Compatibility.
        /// </summary>
        internal static string Compatible {
            get {
                return ResourceManager.GetString("Compatible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Npgsql Compatibility.
        /// </summary>
        internal static string CompatibleDescription {
            get {
                return ResourceManager.GetString("CompatibleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Connection is broken..
        /// </summary>
        internal static string ConnectionBroken {
            get {
                return ResourceManager.GetString("ConnectionBroken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConnectionLifeTime.
        /// </summary>
        internal static string ConnectionLifeTime {
            get {
                return ResourceManager.GetString("ConnectionLifeTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConnectionLifeTime.
        /// </summary>
        internal static string ConnectionLifeTimeDescription {
            get {
                return ResourceManager.GetString("ConnectionLifeTimeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Connection is not open..
        /// </summary>
        internal static string ConnectionNotOpen {
            get {
                return ResourceManager.GetString("ConnectionNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Connection is not set..
        /// </summary>
        internal static string ConnectionNull {
            get {
                return ResourceManager.GetString("ConnectionNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A timeout has occured. If you were establishing a connection, increase Timeout value in ConnectionString. If you were executing a command, increase the CommandTimeout value in ConnectionString or in your NpgsqlCommand object..
        /// </summary>
        internal static string ConnectionOrCommandTimeout {
            get {
                return ResourceManager.GetString("ConnectionOrCommandTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Information used to connect to a PostgreSQL Database, such as &apos;Server=X;Port=X;Database=X;User Id=X;Password=X;&apos;.
        /// </summary>
        internal static string ConnectionStringDescription {
            get {
                return ResourceManager.GetString("ConnectionStringDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection establishment timeout. Increase Timeout value in ConnectionString..
        /// </summary>
        internal static string ConnectionTimeout {
            get {
                return ResourceManager.GetString("ConnectionTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current connection timeout value, &apos;Connect Timeout=X&apos; in the connection string.
        /// </summary>
        internal static string ConnectionTimeoutDescription {
            get {
                return ResourceManager.GetString("ConnectionTimeoutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection is not open.
        /// </summary>
        internal static string ConnNotOpen {
            get {
                return ResourceManager.GetString("ConnNotOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection already open.
        /// </summary>
        internal static string ConnOpen {
            get {
                return ResourceManager.GetString("ConnOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConnectionString cannot be empty..
        /// </summary>
        internal static string ConnStrEmpty {
            get {
                return ResourceManager.GetString("ConnStrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database.
        /// </summary>
        internal static string Database {
            get {
                return ResourceManager.GetString("Database", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database.
        /// </summary>
        internal static string DatabaseDescription {
            get {
                return ResourceManager.GetString("DatabaseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Advanced.
        /// </summary>
        internal static string DataCategory_Advanced {
            get {
                return ResourceManager.GetString("DataCategory_Advanced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context.
        /// </summary>
        internal static string DataCategory_Context {
            get {
                return ResourceManager.GetString("DataCategory_Context", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialization.
        /// </summary>
        internal static string DataCategory_Initialization {
            get {
                return ResourceManager.GetString("DataCategory_Initialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pooling.
        /// </summary>
        internal static string DataCategory_Pooling {
            get {
                return ResourceManager.GetString("DataCategory_Pooling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Security.
        /// </summary>
        internal static string DataCategory_Security {
            get {
                return ResourceManager.GetString("DataCategory_Security", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source.
        /// </summary>
        internal static string DataCategory_Source {
            get {
                return ResourceManager.GetString("DataCategory_Source", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dns hostname lookup timeout. Increase Timeout value in ConnectionString..
        /// </summary>
        internal static string DnsLookupTimeout {
            get {
                return ResourceManager.GetString("DnsLookupTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enlist.
        /// </summary>
        internal static string Enlist {
            get {
                return ResourceManager.GetString("Enlist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enlist.
        /// </summary>
        internal static string EnlistDescription {
            get {
                return ResourceManager.GetString("EnlistDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to establish a connection to &apos;{0}&apos;..
        /// </summary>
        internal static string FailedConnection {
            get {
                return ResourceManager.GetString("FailedConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host.
        /// </summary>
        internal static string Host {
            get {
                return ResourceManager.GetString("Host", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host.
        /// </summary>
        internal static string HostDescription {
            get {
                return ResourceManager.GetString("HostDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t cast {0} into any valid DbType..
        /// </summary>
        internal static string ImpossibleToCast {
            get {
                return ResourceManager.GetString("ImpossibleToCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to numeric value {0} in ConnectionString exceeds maximum value {1}.
        /// </summary>
        internal static string IntegerKeyValMax {
            get {
                return ResourceManager.GetString("IntegerKeyValMax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to numeric value {0} in ConnectionString is below minimum value {1}.
        /// </summary>
        internal static string IntegerKeyValMin {
            get {
                return ResourceManager.GetString("IntegerKeyValMin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IntegratedSecurity.
        /// </summary>
        internal static string IntegratedSecurity {
            get {
                return ResourceManager.GetString("IntegratedSecurity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IntegratedSecurity.
        /// </summary>
        internal static string IntegratedSecurityDescription {
            get {
                return ResourceManager.GetString("IntegratedSecurityDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to expecting {0}=[True/False] value in ConnectionString.
        /// </summary>
        internal static string InvalidBooleanKeyVal {
            get {
                return ResourceManager.GetString("InvalidBooleanKeyVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid database name: {0}.
        /// </summary>
        internal static string InvalidDbName {
            get {
                return ResourceManager.GetString("InvalidDbName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not exist in pg_proc.
        /// </summary>
        internal static string InvalidFunctionName {
            get {
                return ResourceManager.GetString("InvalidFunctionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to expecting {0}=[Numeric] value in ConnectionString.
        /// </summary>
        internal static string InvalidIntegerKeyVal {
            get {
                return ResourceManager.GetString("InvalidIntegerKeyVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid parameter name: {0}.
        /// </summary>
        internal static string InvalidParameterName {
            get {
                return ResourceManager.GetString("InvalidParameterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to expecting {0}=[Protocol Version] value in ConnectionString.
        /// </summary>
        internal static string InvalidProtocolVersionKeyVal {
            get {
                return ResourceManager.GetString("InvalidProtocolVersionKeyVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MaxPoolSize.
        /// </summary>
        internal static string MaxPoolSize {
            get {
                return ResourceManager.GetString("MaxPoolSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MaxPoolSize.
        /// </summary>
        internal static string MaxPoolSizeDescription {
            get {
                return ResourceManager.GetString("MaxPoolSizeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There have been errors on {0}():.
        /// </summary>
        internal static string MediatorErrors {
            get {
                return ResourceManager.GetString("MediatorErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There have been errors on {0}({1}):.
        /// </summary>
        internal static string MediatorErrors_1P {
            get {
                return ResourceManager.GetString("MediatorErrors_1P", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MinPoolSize.
        /// </summary>
        internal static string MinPoolSize {
            get {
                return ResourceManager.GetString("MinPoolSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MinPoolSize.
        /// </summary>
        internal static string MinPoolSizeDescription {
            get {
                return ResourceManager.GetString("MinPoolSizeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string argument missing!.
        /// </summary>
        internal static string MissingConnStrArg {
            get {
                return ResourceManager.GetString("MissingConnStrArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be between {1} and {2}.
        /// </summary>
        internal static string MustBeBetweenXAndY {
            get {
                return ResourceManager.GetString("MustBeBetweenXAndY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nested/Concurrent transactions aren&apos;t supported..
        /// </summary>
        internal static string NoNestedTransactions {
            get {
                return ResourceManager.GetString("NoNestedTransactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No resultset is currently being traversed.
        /// </summary>
        internal static string NoResultSetAvailable {
            get {
                return ResourceManager.GetString("NoResultSetAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No row is available.
        /// </summary>
        internal static string NoRowAvailable {
            get {
                return ResourceManager.GetString("NoRowAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No transaction in progress..
        /// </summary>
        internal static string NoTransaction {
            get {
                return ResourceManager.GetString("NoTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There have been errors on Open().
        /// </summary>
        internal static string OpenError {
            get {
                return ResourceManager.GetString("OpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set NpgsqlDbType to just Array, Binary-Or with the element type (e.g. Array of Box is NpgsqlDbType.Array | NpgsqlDbType.Box)..
        /// </summary>
        internal static string ParameterTypeIsOnlyArray {
            get {
                return ResourceManager.GetString("ParameterTypeIsOnlyArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {0} not found in query..
        /// </summary>
        internal static string ParamNotInQuery {
            get {
                return ResourceManager.GetString("ParamNotInQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        internal static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        internal static string PasswordDescription {
            get {
                return ResourceManager.GetString("PasswordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pooling.
        /// </summary>
        internal static string Pooling {
            get {
                return ResourceManager.GetString("Pooling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pooling.
        /// </summary>
        internal static string PoolingDescription {
            get {
                return ResourceManager.GetString("PoolingDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port.
        /// </summary>
        internal static string Port {
            get {
                return ResourceManager.GetString("Port", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Port.
        /// </summary>
        internal static string PortDescription {
            get {
                return ResourceManager.GetString("PortDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PreloadReader.
        /// </summary>
        internal static string PreloadReader {
            get {
                return ResourceManager.GetString("PreloadReader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PreloadReader.
        /// </summary>
        internal static string PreloadReaderDescription {
            get {
                return ResourceManager.GetString("PreloadReaderDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol Version.
        /// </summary>
        internal static string Protocol {
            get {
                return ResourceManager.GetString("Protocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol Version.
        /// </summary>
        internal static string ProtocolDescription {
            get {
                return ResourceManager.GetString("ProtocolDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The collection is read-only.
        /// </summary>
        internal static string ReadOnlyWriteError {
            get {
                return ResourceManager.GetString("ReadOnlyWriteError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to read from column ordinal &apos;{0}&apos;. With CommandBehavior.SequentialAccess, you may only read from column ordinal &apos;{1}&apos; or greater..
        /// </summary>
        internal static string RowSequentialFieldError {
            get {
                return ResourceManager.GetString("RowSequentialFieldError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Savepoint is not supported by backend..
        /// </summary>
        internal static string SavePointNotSupported {
            get {
                return ResourceManager.GetString("SavePointNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Savepoint name cannot have semicolon..
        /// </summary>
        internal static string SavePointWithSemicolon {
            get {
                return ResourceManager.GetString("SavePointWithSemicolon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SearchPath.
        /// </summary>
        internal static string SearchPath {
            get {
                return ResourceManager.GetString("SearchPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SearchPath.
        /// </summary>
        internal static string SearchPathDescription {
            get {
                return ResourceManager.GetString("SearchPathDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Connection property can&apos;t be changed with an uncommited transaction..
        /// </summary>
        internal static string SetConnectionInTransaction {
            get {
                return ResourceManager.GetString("SetConnectionInTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction property can&apos;t be changed with an uncommited transaction..
        /// </summary>
        internal static string SetTransactionInTransaction {
            get {
                return ResourceManager.GetString("SetTransactionInTransaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A SocketException occured.
        /// </summary>
        internal static string SocketEx {
            get {
                return ResourceManager.GetString("SocketEx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSL.
        /// </summary>
        internal static string SSL {
            get {
                return ResourceManager.GetString("SSL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSL.
        /// </summary>
        internal static string SSLDescription {
            get {
                return ResourceManager.GetString("SSLDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSL Mode.
        /// </summary>
        internal static string SslMode {
            get {
                return ResourceManager.GetString("SslMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSL Mode.
        /// </summary>
        internal static string SslModeDescription {
            get {
                return ResourceManager.GetString("SslModeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ssl connection requested. No Ssl enabled connection from this host is configured..
        /// </summary>
        internal static string SslRequestError {
            get {
                return ResourceManager.GetString("SslRequestError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SyncNotification.
        /// </summary>
        internal static string SyncNotification {
            get {
                return ResourceManager.GetString("SyncNotification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SyncNotification.
        /// </summary>
        internal static string SyncNotificationDescription {
            get {
                return ResourceManager.GetString("SyncNotificationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout.
        /// </summary>
        internal static string Timeout {
            get {
                return ResourceManager.GetString("Timeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout.
        /// </summary>
        internal static string TimeoutDescription {
            get {
                return ResourceManager.GetString("TimeoutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UseExtendedTypes.
        /// </summary>
        internal static string UseExtendedTypes {
            get {
                return ResourceManager.GetString("UseExtendedTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UseExtendedTypes.
        /// </summary>
        internal static string UseExtendedTypesDescription {
            get {
                return ResourceManager.GetString("UseExtendedTypesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username.
        /// </summary>
        internal static string UserName {
            get {
                return ResourceManager.GetString("UserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username.
        /// </summary>
        internal static string UserNameDescription {
            get {
                return ResourceManager.GetString("UserNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to key=value argument incorrect in ConnectionString.
        /// </summary>
        internal static string WrongKeyVal {
            get {
                return ResourceManager.GetString("WrongKeyVal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t cast {0} into NpgsqlParameter.
        /// </summary>
        internal static string WrongType {
            get {
                return ResourceManager.GetString("WrongType", resourceCulture);
            }
        }
    }
}
