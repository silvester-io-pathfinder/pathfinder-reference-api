using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShokisArgument : Template
    {
        public static readonly Guid ID = Guid.Parse("c93eec91-c468-4b13-a400-5b2a8418c42f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shoki's Argument",
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
            yield return new TextBlock { Id = Guid.Parse("d93ea149-6839-4ee7-829b-05708a5b2971"), Type = TextBlockType.Text, Text = "You feel a connection to shokis, the rambling collectors of wayward souls, and might have found old texts written by one. You are trained in Diplomacy. If you were already trained in Diplomacy (from your background or class, for example), you instead become trained in a skill of your choice. You can also cast (spell: disrupt undead) as a divine innate cantrip at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2568bb36-cdc0-4370-b60a-89c0af84599e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
