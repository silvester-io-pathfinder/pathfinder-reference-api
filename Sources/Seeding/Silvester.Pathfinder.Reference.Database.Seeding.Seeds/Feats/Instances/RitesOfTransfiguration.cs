using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitesOfTransfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("154fd82f-1a67-4a4c-9251-067087c8b727");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rites of Transfiguration",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c96fbdee-5e6b-4c4b-a311-907602ad8a82"), Type = TextBlockType.Text, Text = "You can adapt your patron's power to transform other creatures into forms more befitting their behavior or your whims. Your familiar learns (spell: baleful polymorph), even if (spell: baleful polymorph) isn't on your tradition's spell list. By spending 10 minutes in communion with your familiar, you can replace one spell of 6th level or higher you've prepared in one of your witch spell slots with a (spell: baleful polymorph) spell of the same level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c95c64c7-3252-410b-9e36-01dd677471e5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}