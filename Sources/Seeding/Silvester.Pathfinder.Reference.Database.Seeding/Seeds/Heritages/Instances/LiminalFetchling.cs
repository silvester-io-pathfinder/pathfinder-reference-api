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
    public class LiminalFetchling : Template
    {
        public static readonly Guid ID = Guid.Parse("0da4b9fd-d01e-434b-8cba-4d739ee2463c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Liminal Fetchling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3146fbb2-6628-4232-9812-644a9a4a9ad0"), Type = TextBlockType.Text, Text = "You come from a line of fetchlings with a closer connection to the Ethereal Plane and Shadow Planes, and you share those realms' affinity with the in-between and unseen. You gain a +1 circumstance bonus to locate undetected creatures within 60 feet when using the Seek action. Your flat check to target concealed creatures is DC 3 instead of DC 5, and your flat check to target undetected creatures is DC 9 instead of DC 11." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificActionCircumstanceBonus(Guid.Parse("b128c72c-b720-4997-adb7-50dc28a38778"), Actions.Instances.Seek.ID, bonus: 1);
            builder.Manual(Guid.Parse("7132e900-3355-40e4-b5bf-feee3f963fcb"), "Your flat check to target concealed creatures is DC 3 instead of DC 5.");
            builder.Manual(Guid.Parse("d71eed79-ff9b-4834-8ed6-acfcc742e29b"), "Your flat check to target undetected creatures is DC 9 instead of DC 11.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61f7c8ce-55a2-43da-a501-fdc7cb08b253"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 85
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Fetchling.ID;
        }
    }
}
