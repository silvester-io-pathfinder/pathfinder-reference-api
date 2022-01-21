using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class BadlandsOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("99000610-8f66-4096-a925-877cc2d7264d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Badlands Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5e8b7a81-d31a-4323-9185-52ab11884997"), Type = TextBlockType.Text, Text = "You come from sun-scorched badlands, where long legs and an ability to withstand the elements helped you thrive. You can Hustle twice as long while exploring before you have to stop, and you treat environmental heat effects as if they were one step less extreme (incredible heat becomes extreme, extreme heat becomes severe, and so on)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("e80a4d90-6999-43b3-9f0d-d951a4999c15"), "You can Hustle twice as long while exploring before you have to stop");
            builder.ModifyTemperature(Guid.Parse("58a87846-0d9b-4a03-b00f-1b09f9da460d"), Temperature.Heat, ModifierType.Subtract, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4be8026-5211-483e-a53d-ccd9deb10638"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 18
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
