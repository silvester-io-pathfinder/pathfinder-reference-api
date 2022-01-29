using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HuntersDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("a593b193-2513-400c-bcb8-4a371a9e6d5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hunter's Defense",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature with the animal, beast, elemental, fey, fungus, or plant trait attacks you, and you can see the attacker.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b161997a-0b36-402d-822c-86a484605d73"), Type = TextBlockType.Text, Text = $"Your canny understanding of natural and primal creatures helps you predict and dodge their attacks. The triggering attack roll targets your Nature DC instead of your AC. Though this allows you to avoid taking penalties to your AC, it doesn't remove any conditions or other effects causing such penalties. For example, an enemy with sneak attack would still deal extra damage to you for being flat-footed, even though you wouldn't take the –2 circumstance penalty against the attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("34475e50-e476-4943-b235-2fb5d1242c9e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d24e941-b659-484b-8eb0-fb04b28f66cb"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
