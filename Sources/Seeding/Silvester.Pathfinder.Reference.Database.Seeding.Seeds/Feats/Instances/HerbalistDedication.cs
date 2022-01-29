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
    public class HerbalistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("af79274e-77ca-4a4b-a765-eca6d2fc6aca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Herbalist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the herbalist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa429f43-86a3-4bdb-9439-a2f2d035f74f"), Type = TextBlockType.Text, Text = $"You can create remedies and other herbal products. You gain the alchemist's infused reagents class feature, gaining a number of reagents each day equal to your level or half your level if you didn't make your daily preparations in the wilderness. Your advanced alchemy level for creating these is 1 and doesn't increase on its own. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Alchemical Crafting", Feats.Instances.AlchemicalCrafting.ID)} feat. You may only create and choose formulas for herbal items: alchemical items with the {ToMarkdownLink<Models.Entities.Trait>("healing", Traits.Instances.Healing.ID)} trait, plus lesser {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("antidote", Items.AlchemicalElixirs.Instances.Antidote.ID)} and lesser {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("antiplague", Items.AlchemicalElixirs.Instances.Antiplague.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("6bf736fc-2296-4b40-aee2-f1a2d01a7f11"), Type = TextBlockType.Text, Text = $"You become an expert in Nature and can use Nature instead of Crafting to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} herbal items. You don't need to be trained in Crafting and you can use {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("healer's tools", Items.AdventuringGears.Instances.HealersTools.ID)} instead of {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("alchemist's tools", Items.AdventuringGears.Instances.AlchemistsTools.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a8231ce4-e658-468e-9bda-cbacc8f49b70"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("d43c4f1a-1c46-49b6-a656-c0d724b4831a"), Feats.Instances.NaturalMedicine.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a26ca04b-18c4-4e2a-9262-5f03081b6182"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("63fd6aa3-dc4c-48da-8ea6-c07be30bdb43"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59481191-da53-4ca5-a715-62db8be7cf5e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
