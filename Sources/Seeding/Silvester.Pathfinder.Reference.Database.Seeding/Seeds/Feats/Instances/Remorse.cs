using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Remorse : Template
    {
        public static readonly Guid ID = Guid.Parse("8ff208e8-cd5f-448e-abf1-4acde63ea08b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remorse",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acb5acb9-41d8-46cf-b37b-56bcd45d8469"), Type = TextBlockType.Text, Text = "You attempt to overcome your failings, but your guilt stays with you." };
            yield return new TextBlock { Id = Guid.Parse("5c051279-efb3-40e3-a737-dedb286253e8"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: An ally within 30 feet drops to 0 Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("2a33b298-18a2-40ae-8c65-20f56d68f668"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: You (action: Step) or (action: Stride). You must end this movement closer to the triggering ally." };
            yield return new TextBlock { Id = Guid.Parse("a6bb55dc-e160-4e73-85e6-cc042e268a89"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Any spell you cast that restores Hit Points to the triggering ally gets a status bonus to the Hit Points healed equal to the spell’s level, or double the spell’s level if the ally is at 0 Hit Points. Spell: (spell: warrior’s regret)" };
            yield return new TextBlock { Id = Guid.Parse("fddd70ef-a5ba-49cd-8742-39cc7206ac6f"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: Your emotional weight crushes you, leaving you stupefied 2 until you (feat: Settle your Emotions|Settle Emotions)." };
            yield return new TextBlock { Id = Guid.Parse("168508ca-006c-4f0b-b24b-70b1a9901229"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: healer’s blessing)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("813c5d89-4009-42ae-bcb2-ba77bec918b2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
