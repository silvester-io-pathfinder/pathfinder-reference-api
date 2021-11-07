using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("ea8f53f0-d90c-4142-ac18-194a340ed591");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scroll Esoterica",
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
            yield return new TextBlock { Id = Guid.Parse("73b4532a-dd4b-44bd-9407-198ef90eaa7a"), Type = TextBlockType.Text, Text = "Your esoterica collection includes scraps of scriptures, magic tomes, druidic markings, and the like, which you can use to create temporary scrolls. Each day during your daily preparations, you can create a single temporary scroll containing a 1st-level spell of any tradition. The spell must be common, or you must otherwise have access to it. This scroll is an unstable, temporary item and loses its magic the next time you make your daily preparations if you haven’t used it. It can’t be used to (action: Learn the Spell|Learn a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("1ec92cb2-2569-4007-aba5-6a531b09d10d"), Type = TextBlockType.Text, Text = "At 8th level, add a second temporary scroll containing a 2nd-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("392864c5-28b8-4e48-831c-a885a425fac7"), Feats.Instances.ScrollThamaturgy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9c29124-8b57-468b-be47-8ad29ee00ae5"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
