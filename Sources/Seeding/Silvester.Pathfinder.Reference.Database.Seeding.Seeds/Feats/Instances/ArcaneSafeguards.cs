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
    public class ArcaneSafeguards : Template
    {
        public static readonly Guid ID = Guid.Parse("45a11331-ac58-4024-9238-6f16a4377b7e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Safeguards",
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
            yield return new TextBlock { Id = Guid.Parse("86a233a7-a49f-4b55-9b8b-d6b66bb60440"), Type = TextBlockType.Text, Text = $"The magic powering you makes it difficult for outside magic to affect you. You gain the {ToMarkdownLink<Models.Entities.Feat>("Resist Magic", Feats.Instances.ResistMagic.ID)} reaction." };
            yield return new TextBlock { Id = Guid.Parse("15716550-e455-4cf5-adf1-ac2157d3d710"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("c952dfd0-698f-41d3-bc5c-5d9340baaf04"), Type = TextBlockType.Text, Text = $"~ Enhancement: Your safeguards improve. When you {ToMarkdownLink<Models.Entities.Feat>("Resist Magic", Feats.Instances.ResistMagic.ID)}, you gain a number of temporary Hit Points equal to the spell level of the triggering effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82609707-c4a0-4441-be08-c0d8f89c1011"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
