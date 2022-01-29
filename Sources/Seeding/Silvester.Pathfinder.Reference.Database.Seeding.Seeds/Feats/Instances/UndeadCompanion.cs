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
    public class UndeadCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("72a1a1ba-a047-427e-9141-67d3a84184d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undead Companion",
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
            yield return new TextBlock { Id = Guid.Parse("7ec60737-9b38-48cd-9d10-cea149fcba7d"), Type = TextBlockType.Text, Text = $"Your companion is also touched by undeath, a mix of a traditional companion and a skeleton, zombie, or stranger form of unlife. Your companion gains the {ToMarkdownLink<Models.Entities.Trait>("undead", Traits.Instances.Undead.ID)} trait instead of the {ToMarkdownLink<Models.Entities.Trait>("animal", Traits.Instances.Animal.ID)} trait and gains negative healing. It otherwise uses the normal rules for an animal companion or familiar; that means it can still be affected by many conditions or effects to which most undead are immune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("70d56206-b213-411f-a26d-643aa564800d"), or => 
            {
                or.HaveSpecificAnimalCompanionAmount(Guid.Parse("809025f4-0b9d-4807-97ff-b700aba49162"), Comparator.GreaterThanOrEqualTo, amount: 1);
                or.HaveAnyFamiliar(Guid.Parse("6739026c-829a-4623-80c6-0fbb4b6a0dd9"));
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f911018b-bfa3-4661-8029-f7a9e0d2e396"), Traits.Instances.Dhampir.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b60b671e-7dcc-4e1f-81a7-a7f5824968fb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
