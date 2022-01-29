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
    public class EbbAndFlow : Template
    {
        public static readonly Guid ID = Guid.Parse("4d75a5e2-3fa1-4399-bce3-0c4594d7c4ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ebb and Flow",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0994ab6-4df4-4768-bdc6-aa84e347766f"), Type = TextBlockType.Text, Text = $"You can pull forth both positive and negative energy simultaneously to harm your enemies and heal your allies. If your next action is to cast a 1-action or 2-action {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} or {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell, choose one creature in range that would be harmed by the spell, and choose another creature within range that would be healed by the spell. Your heal or harm targets both creatures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c8ec6d0e-41de-43b1-91a4-ba6dff19dc46"), Feats.Instances.VersatileFont.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a798e598-9692-4908-a266-1b7ca7801b4b"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("1ad90bd1-3131-4b8e-b56f-187de3afc895"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("41c01667-a306-460a-a109-1be41758e0d1"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17694675-c062-413e-9926-36ac2fffaeb3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
