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
    public class ImplausibleEsloterica : Template
    {
        public static readonly Guid ID = Guid.Parse("98d8a35b-297b-445f-a5ac-d441411f94f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implausible Esloterica",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39ffb02e-66de-49b3-b46e-be886e4d318f"), Type = TextBlockType.Text, Text = $"It seems impossible, but your esoterica are so eclectic and complete that you can keep pulling out exactly the item you need, even in far-flung locations. You can use {ToMarkdownLink<Models.Entities.Feat>("Prescient Planner", Feats.Instances.PrescientPlanner.ID)} even if you've already used it after purchasing goods, and you can use it as a single action instead of a 2-action activity, during which you {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to draw the item." };
            yield return new TextBlock { Id = Guid.Parse("05c2bd9e-aa37-4cc9-b6c1-e2f830daa975"), Type = TextBlockType.Text, Text = $"In addition, five times per day, you can use {ToMarkdownLink<Models.Entities.Feat>("Prescient Planner", Feats.Instances.PrescientPlanner.ID)} to pull out a common consumable item of a level up to 6 levels lower than your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c3629500-aa5b-4d91-a3d8-1e1acd664a6a"), Feats.Instances.HandyEsoterica.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba173467-e065-4146-9cb9-bddc442948c2"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
