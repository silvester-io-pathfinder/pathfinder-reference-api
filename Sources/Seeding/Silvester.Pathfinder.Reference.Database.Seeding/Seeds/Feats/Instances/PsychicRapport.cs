using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PsychicRapport : Template
    {
        public static readonly Guid ID = Guid.Parse("405c2b5d-a7e3-4ccc-8bd4-bed20555c0d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Psychic Rapport",
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
            yield return new TextBlock { Id = Guid.Parse("18299067-e7d3-4178-ad02-709b97650c29"), Type = TextBlockType.Text, Text = "Your telepathic sensitivity intensifies when you're affected by mental magic, making it easier for you to link to other creatures. When you're affected by a (trait: mental) spell or have cast a (trait: mental) spell this round, you gain a +1 circumstance bonus on Deception, Diplomacy, and Intimidation checks, and on Perception checks to (action: Sense Motive)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da370573-6fed-4497-85fd-4dbdc226af68"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
