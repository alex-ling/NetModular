// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 16.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Nm.Module.CodeGenerator.Infrastructure.Templates.Default.T4.src.UI.App
{
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class VueConfig : VueConfigBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"const path = require('path')
const CopyWebpackPlugin = require('copy-webpack-plugin')
const UglifyJsPlugin = require('uglifyjs-webpack-plugin')
const isDev = process.env.NODE_ENV === 'development' // 开发环境

// 增加环境变量
process.env.VUE_APP_BUILD_TIME = require('dayjs')().format('YYYYMDHHmmss')
// 打包输出路径
const outputDir = '../../WebHost/wwwroot/app'

module.exports = {
  outputDir: outputDir,
  publicPath: '/app',
  devServer: {
    port: ");
            
            #line 16 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Project.No + 5220));
            
            #line default
            #line hidden
            this.Write("\r\n  },\r\n  transpileDependencies: [\'");
            
            #line 18 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-.*\', \'element-ui\'],\r\n  configureWebpack: {\r\n    plugins: [\r\n      /**\r\n       * " +
                    "复制");
            
            #line 22 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-lib-skins/public目录下的文件到输出目录\r\n       */\r\n      new CopyWebpackPlugin([\r\n        {" +
                    "\r\n          from: path.join(__dirname, \'node_modules/");
            
            #line 26 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write(@"-lib-skins/public'),
          to: path.join(__dirname, outputDir),
          ignore: ['index.html']
        }
      ])
    ]
  },
  chainWebpack: config => {
    /**
     * 删除懒加载模块的 prefetch preload，降低带宽压力
     * https://cli.vuejs.org/zh/guide/html-and-static-assets.html#prefetch
     * https://cli.vuejs.org/zh/guide/html-and-static-assets.html#preload
     * 而且预渲染时生成的 prefetch 标签是 modern 版本的，低版本浏览器是不需要的
     */
    config.plugins.delete('prefetch').delete('preload')

    /**
     * 设置index.html模板路径，使用");
            
            #line 43 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-lib-skins/public中的模板\r\n     */\r\n    config.plugin(\'html\').tap(args => {\r\n      ar" +
                    "gs[0].template = \'./node_modules/");
            
            #line 46 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write(@"-lib-skins/public/index.html'
      return args
    })

    config
      // 开发环境
      .when(
        isDev,
        // sourcemap不包含列信息
        config => config.devtool('cheap-source-map')
      )
      // 非开发环境
      .when(!isDev, config => {
        config.optimization.minimizer([
          new UglifyJsPlugin({
            uglifyOptions: {
              // 移除 console
              // 其它优化选项 https://segmentfault.com/a/1190000010874406
              warnings: false,
              compress: {
                drop_console: true,
                drop_debugger: true,
                pure_funcs: ['console.log']
              }
            }
          })
        ])

        // 拆分
        config.optimization.splitChunks({
          chunks: 'all',
          cacheGroups: {
            elementUI: {
              name: 'chunk-element-ui',
              priority: 20,
              test: /[\\/]node_modules[\\/]element-ui(.*)/
            },
            skins: {
              name: 'chunk-skins',
              priority: 10,
              test: /[\\/]node_modules[\\/]");
            
            #line 86 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\UI\App\VueConfig.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write("-lib-skins(.*)/\r\n            }\r\n          }\r\n        })\r\n\r\n        config.optimiz" +
                    "ation.runtimeChunk({\r\n          name: \'manifest\'\r\n        })\r\n      })\r\n  }\r\n}\r\n" +
                    "");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class VueConfigBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
