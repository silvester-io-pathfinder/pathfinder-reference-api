using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("693fe34f-b2f4-440c-b66f-3014adc9a1b2");

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
            yield return new TextBlock { Id = Guid.Parse("154ce1f3-bb3b-4b9e-b7f7-b5394f9aaf4c"), Type = TextBlockType.Text, Text = "Your esoterica collection includes scraps of scriptures, magic tomes, druidic markings, and the like, which you can use to create temporary scrolls. Each day during your daily preparations, you can create a single temporary scroll containing a 1st-level spell of any tradition. The spell must be common, or you must otherwise have access to it. This scroll is an unstable, temporary item and loses its magic the next time you make your daily preparations if you haven’t used it. It can’t be used to (action: Learn the Spell|Learn a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("821fae6f-2bb8-467c-aee3-cc77c00e7e53"), Type = TextBlockType.Text, Text = "At 8th level, add a second temporary scroll containing a 2nd-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("748730e3-018a-4610-aeef-fe65702b2a85"), Feats.Instances.ScrollThaumaturgy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45a28169-5109-461e-934d-89386f0e6329"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
