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
    public class EclecticPolymath : Template
    {
        public static readonly Guid ID = Guid.Parse("f9a9e5b8-3cb8-4161-9fc7-0cb2fdc77b64");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Polymath",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a207b80d-ec48-433e-bdaa-f007e9f6f70b"), Type = TextBlockType.Text, Text = $"Your flexible mind can quickly shift spells. If you add a spell to your repertoire during your daily preparations using {ToMarkdownLink<Models.Entities.Feat>("Esoteric Polymath", Feats.Instances.EsotericPolymath.ID)}, when you prepare again, you can choose to keep the new spell from {ToMarkdownLink<Models.Entities.Feat>("Esoteric Polymath", Feats.Instances.EsotericPolymath.ID)} in your repertoire and instead lose access to another spell of the same level in your repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5933d3bb-77e1-4bec-9139-40e6373437e7"), Feats.Instances.EsotericPolymath.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a067e68b-ebf4-450d-91f7-8c007a9a7d0d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
