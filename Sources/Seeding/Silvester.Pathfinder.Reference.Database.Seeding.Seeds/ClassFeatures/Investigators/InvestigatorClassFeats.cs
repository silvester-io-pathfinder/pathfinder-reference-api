using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Investigators
{
    public class InvestigatorClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("ca5a98e7-d130-4c76-9ac9-e75008a1f861");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Investigator Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fa34bb09-12f6-4c18-a446-f9f7e02fb233"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level, you gain an investigator class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("e7934bae-a97e-4f52-a856-73b1e5f7d24f"), Guid.Parse("381232d5-e116-4f71-ba1f-ec08ec8905f0"), Classes.Instances.Investigator.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("f8d239ff-14f0-448d-b421-7ed1f10cb426"), Guid.Parse("4911f6bf-5933-40a9-9dfb-aa4f9f1f87f9"), Classes.Instances.Investigator.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("a3a94c37-09ba-45f8-9465-107958d54e29"), Guid.Parse("2fda763e-8ff5-4ece-8464-80d15943e61d"), Classes.Instances.Investigator.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("e9655863-ecd5-4894-b3d8-b5e961445f63"), Guid.Parse("162ca246-7464-45b4-b0bc-405c27b9e720"), Classes.Instances.Investigator.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("aa0dc564-3785-41a8-96f1-4d7902ab6cf9"), Guid.Parse("075b0e78-4539-43c8-8acb-e0f1d68e58ba"), Classes.Instances.Investigator.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("6d8ab57e-d488-4caf-ad41-3139861b6a31"), Guid.Parse("c5d5a023-3b98-416f-808c-b4bb835d87ff"), Classes.Instances.Investigator.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("db22907e-8986-4730-ba5e-faf772c8e7e0"), Guid.Parse("52784845-b922-44ad-9ded-47920b45c747"), Classes.Instances.Investigator.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("ad089e6f-34a6-42f1-846d-bb0686ebca8e"), Guid.Parse("3c7f098f-a109-45d0-ae2b-864a93386668"), Classes.Instances.Investigator.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("180e5080-736c-42e5-910c-3f640209cec4"), Guid.Parse("45bdc3c0-e0b1-4d9e-bd1f-ba60fca3c7d7"), Classes.Instances.Investigator.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("bec8b14a-1b83-47b9-bb5d-d423aa2df589"), Guid.Parse("32940f25-772c-4627-bcbc-662548ed3249"), Classes.Instances.Investigator.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("f77d7090-cfce-4d1d-903e-77d06c4b652a"), Guid.Parse("a85753f7-267a-4e38-8314-75b8313eb9fa"), Classes.Instances.Investigator.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0850fdf-4929-41b8-9c3a-6d8003c268cb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 58
            };
        }
    }
}
