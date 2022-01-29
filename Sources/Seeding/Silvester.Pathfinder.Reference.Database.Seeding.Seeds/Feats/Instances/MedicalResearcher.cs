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
    public class MedicalResearcher : Template
    {
        public static readonly Guid ID = Guid.Parse("14894bdb-11ef-45a4-af5e-df669bd403f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Medical Researcher",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21a1ec1c-1c4c-48ac-9d91-e5748afafd83"), Type = TextBlockType.Text, Text = $"Kassi has taught you not only how to apply medicines with your medical skills but how to craft them as well. When you {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("healer's kits", Items.AdventuringGears.Instances.HealersTools.ID)}, minor {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("vaccines", Items.AlchemicalElixirs.Instances.Vaccine.ID)}, lesser {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("addiction suppressants", Items.AlchemicalElixirs.Instances.AddictionSuppressant.ID)}, lesser {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("antidotes", Items.AlchemicalElixirs.Instances.Antidote.ID)}, lesser {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("antiplagues", Items.AlchemicalElixirs.Instances.Antiplague.ID)}, minor {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("elixirs of life", Items.AlchemicalElixirs.Instances.ElixirOfLife.ID)}, or other non-magical medical or healing items, you can use Medicine instead of Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6308db64-41f2-40b4-8476-f3e615d21276"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e901acb-bf4a-4b4d-ac68-d45772b3546c"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
