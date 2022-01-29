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
    public class SynergisticSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("2b281a7f-ac09-4719-8e97-47cf2a89b11a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Synergistic Spell",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa9f2f05-2afa-472f-a3bc-f5ef0bd77462"), Type = TextBlockType.Text, Text = $"You combine your synergy and spells into a fantastic web of magic, allowing you to cast two spells at once. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from one of your halcyon spell slots, after that spell resolves, you can Cast another Spell as a free action. This spell must be cast from one of your halcyon spell slots and be a spell that would normally take two actions to cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ba902b97-33b6-4374-8136-6aaa1eddfac8"), Feats.Instances.HalcyonSpellcastingInitiate.ID);
            builder.HaveSpecificFeat(Guid.Parse("58819f47-ba76-434a-8942-c64c95828eb4"), Feats.Instances.FulminatingSynergy.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9dc81af0-70ea-442c-b840-1cae2ea1acf5"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("b1e6795a-2432-49ff-924b-f0fd00758d3b"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("beca4745-27be-491f-b0e9-a918ac02c941"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
