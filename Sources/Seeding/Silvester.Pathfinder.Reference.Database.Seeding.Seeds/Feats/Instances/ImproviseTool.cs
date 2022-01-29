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
    public class ImproviseTool : Template
    {
        public static readonly Guid ID = Guid.Parse("8496e5ab-587e-4723-9bbb-4787cbbe13f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvise Tool",
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
            yield return new TextBlock { Id = Guid.Parse("457fcec1-77ab-4204-b6fa-cb1ca18b970a"), Type = TextBlockType.Text, Text = $"You can jury-rig solutions when you don't have the proper tools on hand. You can attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Repair", SkillActions.Instances.Repair.ID)} damaged items without a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("repair kit", Items.AdventuringGears.Instances.RepairKit.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("2a667415-812c-4288-8e81-5fa9906fb11f"), Type = TextBlockType.Text, Text = $"If you have the raw materials available, you can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} a basic {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("caltrop set", Items.AdventuringGears.Instances.Caltrops.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("candle", Items.AdventuringGears.Instances.Candle.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("compass", Items.AdventuringGears.Instances.Compass.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("crowbar", Items.AdventuringGears.Instances.Crowbar.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("fishing tackle", Items.AdventuringGears.Instances.FishingTackle.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("flint and steel", Items.AdventuringGears.Instances.FlintAndSteel.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("hammer", Items.AdventuringGears.Instances.Hammer.ID)}, 10-foot {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("ladder", Items.AdventuringGears.Instances.Ladder.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("piton", Items.AdventuringGears.Instances.Piton.ID)},  50 feet {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("rope", Items.AdventuringGears.Instances.Rope.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("10-foot pole", Items.AdventuringGears.Instances.TenFootPole.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("replacement thieves' picks", Items.AdventuringGears.Instances.ThievesTools.ID)}, long or short {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("tool", Items.AdventuringGears.Instances.Tool.ID)}, or {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("torch", Items.AdventuringGears.Instances.Torch.ID)} without consulting a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("basic crafter's book", Items.AdventuringGears.Instances.BasicCraftersBook.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("79a985ca-536c-4952-943b-52519b9cb08f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
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
                Id = Guid.Parse("fe3b685f-98e2-4b28-839b-64d5ef3f6949"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
