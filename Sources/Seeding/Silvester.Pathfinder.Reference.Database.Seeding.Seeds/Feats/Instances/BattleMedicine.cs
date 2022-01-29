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
    public class BattleMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("634bfb27-61f8-40b5-9cef-ee337821dff0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Medicine",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e37558c3-f4d9-411f-8f35-d5e2e92f6616"), Type = TextBlockType.Text, Text = $"You can patch up yourself or an adjacent ally, even in combat. Attempt a Medicine check with the same DC as for {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}, and restore a corresponding amount of Hit Points; this does not remove the wounded condition. As with {ToMarkdownLink<Models.Entities.SkillAction>("Treat Wounds", SkillActions.Instances.TreatWounds.ID)}, you can attempt checks against higher DCs if you have the minimum proficiency rank. The target is then temporarily immune to your Battle Medicine for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ddd8f378-a8eb-427e-b3fa-373c8c7752c2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f89bea6f-8dc5-4259-a92f-445d11dcec40"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("9a9a0972-892c-46a4-8907-5d8dad9213ba"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("860afdda-e176-41b7-825a-b105f0ac0ee3"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("1bf8eca9-8f84-43bd-90ac-9e8b1375fb72"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7899700f-8ba7-439e-ab79-fffb444b5fc5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
