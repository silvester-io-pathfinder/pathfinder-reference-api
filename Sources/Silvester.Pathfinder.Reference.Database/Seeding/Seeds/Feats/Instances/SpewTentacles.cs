using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpewTentacles : Template
    {
        public static readonly Guid ID = Guid.Parse("b6727fc8-1426-4f56-8114-a6dc1a352a54");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spew Tentacles",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3455f11e-df30-4e29-a48a-8291be2af7e0"), Type = TextBlockType.Text, Text = "You can open your mouth to an immense size and spew forth an impossibly large field of tentacles. You can cast (spell: black tentacles) once per day as an innate occult spell, though when you do so, you spew them from your mouth out to the appropriate range, where they take root and begin (action: Grappling | Grapple) creatures as usual. The tentacles recognize you as a part of them and don’t attempt to (action: Grapple) you, even if you are in the area." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32c20f49-6aa2-4186-b18c-65d33b271dfd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
