using System;

namespace Dnad.Architects.CertificateManagement.Domain.Models.ValueObjects
{
    public class CertificateUriDownload
    {
        public int Code { get; private set; }
        public string Uri { get; private set; }
        public long ExpiresOn { get; private set; }

        public CertificateUriDownload(string uri, long expiresOn)
        {
            Uri = uri;
            ExpiresOn = expiresOn;
        }
    }
    
    
    public class CertificateUriUpload
    {
        public int Code { get; private set; }
        public string Uri { get; private set; }
        public long ExpiresOn { get; private set; }

        public CertificateUriUpload(string uri, long expiresOn)
        {
            Uri = uri;
            ExpiresOn = expiresOn;
        }
    }    
}