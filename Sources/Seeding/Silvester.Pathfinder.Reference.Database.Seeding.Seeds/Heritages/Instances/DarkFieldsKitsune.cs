using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class DarkFieldsKitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("2af7252a-ec4b-4d0d-88bd-bef04c9a5035");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Dark Fields Kitsune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1fd34d33-61ac-4a34-9573-2f876785c720"), Type = TextBlockType.Text, Text = "You can exert your unsettling presence to subtly Demoralize others. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don't take a penalty when you attempt to Demoralize a creature that doesn't understand your language. You also gain the Invigorating Fear reaction. Your alternate form is a fox, which has the statistics of 1st-level pest form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("fb567f59-555b-414a-943c-0b5e3732376a"), "You can exert your unsettling presence to subtly Demoralize others. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don't take a penalty when you attempt to Demoralize a creature that doesn't understand your language.");
            builder.GainSpecificFeat(Guid.Parse("f2104911-7674-419d-a4cf-fc2587ea7393"), Feats.Instances.InvigoratingFear.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6966d90-5988-403e-8eb5-0534682ac0b2"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kitsune.ID;
        }
    }
}
