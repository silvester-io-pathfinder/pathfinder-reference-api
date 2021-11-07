using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("01ab566f-2269-41ba-8d47-0826610dda32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Trickster",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5ccea4be-7478-4774-b86e-dfe45121c836"), Type = TextBlockType.Text, Text = "Whether you’re using magic items, wielding innate magic, or dabbling in spellcasting, you can sneak spells past your foes’ defenses as easily as any blade. When you succeed at a spell attack roll against a flat-footed foe’s AC and the spell deals damage, you can add your sneak attack damage to the damage roll. If your single spell leads to multiple separate damage rolls, apply your sneak attack damage only once per target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("670e10ee-3216-4cd3-a51e-e4b630a56584"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
