using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Remorse : Template
    {
        public static readonly Guid ID = Guid.Parse("3b5fb755-dc7f-444d-b7b4-db0db0cdfbcf");

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
            yield return new TextBlock { Id = Guid.Parse("66acf520-63ca-4d5a-bd89-de463dcd299f"), Type = TextBlockType.Text, Text = "You attempt to overcome your failings, but your guilt stays with you." };
            yield return new TextBlock { Id = Guid.Parse("cacdc652-0590-4aa1-af35-c0ab768d5eb2"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: An ally within 30 feet drops to 0 Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("9d50ce10-46ed-4ba3-aa11-c651d71bd08a"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: You (action: Step) or (action: Stride). You must end this movement closer to the triggering ally." };
            yield return new TextBlock { Id = Guid.Parse("b1b65d99-6095-4ed3-8fb0-e6cad2061c34"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Any spell you cast that restores Hit Points to the triggering ally gets a status bonus to the Hit Points healed equal to the spell’s level, or double the spell’s level if the ally is at 0 Hit Points. Spell: (spell: warrior’s regret)" };
            yield return new TextBlock { Id = Guid.Parse("d650cdeb-9aed-4ba7-942c-d7edb6f2c812"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: Your emotional weight crushes you, leaving you stupefied 2 until you (feat: Settle your Emotions|Settle Emotions)." };
            yield return new TextBlock { Id = Guid.Parse("ed5efffc-8805-4717-9a77-afa85d4c14c5"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: healer’s blessing)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dc3b4a9-cecb-4843-a19d-a0bbbafdf206"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
