using MvCamCtrl.NET;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AcqDevice
{
    internal class CameraHK : CameraBase
    {
        CCamera camera = new CCamera();
        CCameraInfo cameraInfo;
        float exposure;
        public override float Exposure { 
            get => exposure;
            set {

                ;
            }
        }}

        public override float ExposureMax => throw new NotImplementedException();

        public override float ExposureMin => throw new NotImplementedException();

        public override float Gain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override float Heartbeat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string NameOrIP { get ; set ; }

        public override int CloseDevice()
        {            
            throw new NotImplementedException();
        }

        public override int CreateHandle()
        {
            throw new NotImplementedException();
        }

        public override int DestroyHandle()
        {
            throw new NotImplementedException();
        }

        public override int OpenDevice()
        {
            throw new NotImplementedException();
        }

        public override int StartGrabbing()
        {
            throw new NotImplementedException();
        }

        public override int StopGrabbing()
        {
            throw new NotImplementedException();
        }
    }
}
