using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("41ca9932-0894-420f-975d-8c7c56897cae");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("63491aa4-fc4b-4e39-8422-a03e19cb393c"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("6475ed42-6097-48e7-bc3c-91f698d8c084"), Guid.Parse("ef45139d-9fd1-4a6b-b767-630a5965c997"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("990096fb-6e84-4ac4-9651-a7758477bfb7"), Guid.Parse("e0c5073f-a8e6-44e0-969f-c15917ceb65d"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("711b18ce-ab88-48fa-8845-ad27220687a9"), Guid.Parse("310867db-b444-42f3-9be0-c891ac335467"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("e996afb4-3d4f-470a-be01-1d7aa62e9290"), Guid.Parse("97c079cd-d9d6-4658-b67f-142f8499cc92"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("77fe01b4-7c23-4fe4-9988-2d283c02a518"), Guid.Parse("0713dcf3-98b4-44dc-939f-429f9a83c575"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2593f1d3-32da-4a08-8465-92efbaf3c81e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 70
            };
        }
    }
}
