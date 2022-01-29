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
    public class CharredRemains : Template
    {
        public static readonly Guid ID = Guid.Parse("b7b0837e-48d0-4db3-8f7f-5075d0e23ecd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Charred Remains",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8749837e-d72a-414c-a070-bad184b1254a"), Type = TextBlockType.Text, Text = $"Your next fire spell leaves embers in its wake. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} with an area and the {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)} trait, for 1 minute, your spell's area becomes difficult terrain as well as hazardous terrain, dealing 1 fire damage for each square a creature moves through." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d646f1da-402d-400e-8b08-28f7360545ca"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("e8861548-4bb8-4822-ad54-33e1cca6a9e6"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("ec6134cc-14b3-44d2-b7e3-5ab8c24a4ce6"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("faa08879-8659-46b3-a97f-b7336603f7da"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
