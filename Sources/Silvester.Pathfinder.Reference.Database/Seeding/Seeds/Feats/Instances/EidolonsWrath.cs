using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EidolonsWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("3de59726-22c4-4e94-aa1f-c4ee0bdbe32c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidolon's Wrath",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a465c287-790e-42a3-8271-6d287aba084c"), Type = TextBlockType.Text, Text = "Your eidolon gains the (spell: eidolon’s wrath) focus spell, which it casts, instead of you. You determine the damage type when you gain the feat: acid, cold, electricity, fire, negative, positive, or sonic. If your eidolon is a celestial, fiend, or monitor with an alignment other than true neutral, you can choose a damage type in its alignment. Increase the number of Focus Points in your focus pool by 1. As normal, your eidolon shares your Focus Points." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31967866-7028-45b1-8938-88c2c4ff49d6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
