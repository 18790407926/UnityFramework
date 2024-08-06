/*
* FileName:          IUIGroupHelper
* CompanyName:       
* Author:            relly
* Description:       
*/


namespace Framework.UI
{
    /// <summary>
    /// 界面组辅助器接口。
    /// </summary>
    public interface IUIGroupHelper
    {
        /// <summary>
        /// 设置界面组深度。
        /// </summary>
        /// <param name="depth">界面组深度。</param>
        void SetDepth(int depth);

        /// <summary>
        /// 设置Canvas RenderMode 0/1/2
        /// </summary>
        /// <param name="mode"></param>
        void SetRenderMode(int mode);
    }
}
