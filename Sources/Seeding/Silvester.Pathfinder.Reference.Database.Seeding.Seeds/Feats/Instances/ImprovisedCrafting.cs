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
    public class ImprovisedCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("eb33a10e-0a81-4967-b353-2543c2ecc387");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvised Crafting",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6c7b033-472b-44a5-8718-51fe87b51f1c"), Type = TextBlockType.Text, Text = $"You've learned to repair your equipment even in challenging circumstances, making use of what you have available. You can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} an item without a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("repair kit", Items.AdventuringGears.Instances.RepairKit.ID)}, instead improvising tools out of your gear or found items. This adds 5 minutes to the time it takes to {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} the item. You can also {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} an item while on the move without needing a stable surface. This adds 10 minutes to the times it takes to {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} the item." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bdae461f-166c-4a3a-bc18-24949640993b"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ad86932f-41b1-42f4-8b57-04cb99a7da2e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1c077e54-495a-45c3-9cae-0b2faa58e3ba"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("78183d29-8ea5-4ca1-9ea4-cf143377d0e1"), Traits.Instances.Exploration.ID);
            builder.Add(Guid.Parse("601bdfa4-c0e5-4b36-81c9-cfd444e5b304"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("6211082b-6776-48d8-a38a-1f8e7eb466ae"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("581c3265-63c4-43df-959b-7bc68d3062db"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
