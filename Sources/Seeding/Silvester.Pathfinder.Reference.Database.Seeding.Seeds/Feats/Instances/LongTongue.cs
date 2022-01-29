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
    public class LongTongue : Template
    {
        public static readonly Guid ID = Guid.Parse("4dc522da-29f8-4f3b-bb0a-413076ad2ae4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Long Tongue",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0444a559-4513-4b65-9833-69d6b3d5d0a2"), Type = TextBlockType.Text, Text = $"You've learned to stretch your exceptionally long tongue beyond its original limits. When you use your tongue to deliver touch range spells or perform very simple {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions, you can do so at a distance that is 5 feet beyond your usual reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("9775e095-91f0-49b4-96ff-42a16eace846"), Heritages.Instances.SnaptongueGrippli.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7f25e49e-ced0-4db0-b810-cf844108a35c"), Traits.Instances.Grippli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8eaa9e3a-bd62-4c5f-8a17-e62c41b7faa9"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
