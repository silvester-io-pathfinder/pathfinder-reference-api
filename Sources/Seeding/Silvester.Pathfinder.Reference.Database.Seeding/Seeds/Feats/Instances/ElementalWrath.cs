using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("40c251b2-6dd5-467e-8d83-825b4706e10a");

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
            yield return new TextBlock { Id = Guid.Parse("d66efb8c-0b26-46b5-9312-d3dcc77b5cab"), Type = TextBlockType.Text, Text = "You are so attuned to the land that you can call forth a bolt of energy from your surroundings. When you gain this feat, select (trait: acid), (trait: cold), (trait: electricity), or (trait: fire). You can call to the land to cast the (spell: acid splash) cantrip as an innate primal spell at will, except the spell has only verbal components and deals the type of damage you chose instead of acid damage; the spell gains the trait appropriate to its damage instead of the (trait: acid) trait. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bfd5959-ae66-487c-b6b4-61b89976d719"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
