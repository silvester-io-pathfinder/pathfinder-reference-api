using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EndureDeathsTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("6bba77f9-fba4-4016-9322-e5ffdc480e29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Endure Death's Touch",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An undead hits you with an unarmed attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("50bc0555-a509-4d56-afed-d7dd218210be"), Type = TextBlockType.Text, Text = "Your conviction redirects the undead’s attack through your armor and then harmlessly away. You gain resistance 5 to physical damage and resistance 10 to negative damage against the triggering attack. You gain a +2 circumstance bonus on any saving throws against effects from the undead’s natural attack; if you succeed at the saving throw, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dab827e3-4a79-4019-868f-ee052a373de4"), Feats.Instances.KnightVigilantDedication.ID);
            builder.AddOr(Guid.Parse("2182482d-d4f1-49dd-ab3b-8cf53b477065"), or => 
            {
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("8d6dd77c-229d-47ff-a429-4f441862d9ce"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Medium.ID);
                or.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("e4f00346-bba0-4601-80cd-e2710f67c277"), Proficiencies.Instances.Expert.ID, ArmorCategories.Instances.Heavy.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56218a52-601a-4b88-8f55-bf91ed1a92b5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
