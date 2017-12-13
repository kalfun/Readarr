using FluentValidation;
using NzbDrone.Core.Annotations;
using NzbDrone.Core.ThingiProvider;
using NzbDrone.Core.Validation;

namespace NzbDrone.Core.Extras.Metadata.Consumers.Wdtv
{
    public class WdtvSettingsValidator : AbstractValidator<WdtvMetadataSettings>
    {
    }

    public class WdtvMetadataSettings : IProviderConfig
    {
        private static readonly WdtvSettingsValidator Validator = new WdtvSettingsValidator();

        public WdtvMetadataSettings()
        {
            TrackMetadata = true;
            ArtistImages = true;
            AlbumImages = true;
        }

        [FieldDefinition(0, Label = "Track Metadata", Type = FieldType.Checkbox)]
        public bool TrackMetadata { get; set; }

        [FieldDefinition(1, Label = "Artist Images", Type = FieldType.Checkbox)]
        public bool ArtistImages { get; set; }

        [FieldDefinition(2, Label = "Album Images", Type = FieldType.Checkbox)]
        public bool AlbumImages { get; set; }
        
        public bool IsValid => true;

        public NzbDroneValidationResult Validate()
        {
            return new NzbDroneValidationResult(Validator.Validate(this));
        }
    }
}
