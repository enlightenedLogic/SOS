using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SOS.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Metro m_Metro;

            public Metro Metro
            {
                [DebuggerHidden]
                get
                {
                    m_Metro = Create__Instance__(m_Metro);
                    return m_Metro;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Metro))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Metro);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public SOS m_SOS;

            public SOS SOS
            {
                [DebuggerHidden]
                get
                {
                    m_SOS = Create__Instance__(m_SOS);
                    return m_SOS;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_SOS))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_SOS);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public Splash m_Splash;

            public Splash Splash
            {
                [DebuggerHidden]
                get
                {
                    m_Splash = Create__Instance__(m_Splash);
                    return m_Splash;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Splash))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Splash);
                }
            }

        }


    }
}