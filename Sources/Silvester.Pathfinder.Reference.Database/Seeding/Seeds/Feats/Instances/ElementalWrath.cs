using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("319a6523-0158-477f-a2e3-d97a2b8b9fb0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Wrath",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef9d4e8e-e50b-48a1-97a0-e98d7c6234d2"), Type = TextBlockType.Text, Text = "You are so attuned to the land that you can call forth a bolt of energy from your surroundings. When you gain this feat, select (trait: acid), (trait: cold), (trait: electricity), or (trait: fire). You can call to the land to cast the (spell: acid splash) cantrip as an innate primal spell at will, except the spell has only verbal components and deals the type of damage you chose instead of acid damage; the spell gains the trait appropriate to its damage instead of the (trait: acid) trait. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3537731c-01a7-45bc-8636-4ce2f579e214"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
