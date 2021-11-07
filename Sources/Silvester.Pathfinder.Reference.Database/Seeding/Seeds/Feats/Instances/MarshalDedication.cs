using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarshalDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9d4bbe8c-c58c-4668-b2ba-49d28fb64876");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Marshal Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the marshal archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0972408c-5a27-4908-907b-c109d4b14ab0"), Type = TextBlockType.Text, Text = "You’ve combined your social skills and combat training to become a talented combat leader. Choose Diplomacy or Intimidation. You become trained in that skill or become an expert if you were already trained in it." };
            yield return new TextBlock { Id = Guid.Parse("775c5e59-0e18-4892-befb-0d1ba8499ddc"), Type = TextBlockType.Text, Text = "In addition, you’re surrounded by a marshal’s aura in a 10-foot emanation. Your aura has the (trait: emotion), (trait: mental), and (trait: visual) traits and grants you and allies within the aura a +1 status bonus to saving throws against (trait: fear) effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("18b4d5de-b78d-46c2-b6d7-dc4a150cbe5d"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
            builder.AddOr(Guid.Parse("35703fab-385b-4fcc-a81f-11ed8a86d32c"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("cb2b7abb-1373-4723-8024-a632bcc2547e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("da0fb914-14ba-4961-899e-910509c66f19"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
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
                Id = Guid.Parse("d9d1b3a0-ea4c-4afd-aab0-9f14c85d1b93"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
