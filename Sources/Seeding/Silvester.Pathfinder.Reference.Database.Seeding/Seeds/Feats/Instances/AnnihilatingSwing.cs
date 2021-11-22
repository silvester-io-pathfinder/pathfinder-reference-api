using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnnihilatingSwing : Template
    {
        public static readonly Guid ID = Guid.Parse("ad7d8f15-7507-4690-8a5a-5db4b5c9999a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Annihilating Swing",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e5cc9e6-e699-4788-b599-26722a342583"), Type = TextBlockType.Text, Text = "You have learned from the brute destructive power of xulgaths and their kind. You make a melee (action: Strike) that ignores any resistances the target has. If you target a solid unattended object or surface with your (action: Strike), you might automatically destroy it without an attack roll. If you target any object or surface with Hardness 20 or less that isn't a magic item or the effect of a spell, you destroy it. If the target object or surface is a magic item or the effect of a spell, you attempt to counteract it using your attack bonus with the (action: Strike) for the counteract check. On a successful counteract check, you destroy the object or surface unless it has Hardness greater than 20, is an artifact, or is similarly difficult to destroy. You destroy up to a 5-foot cube of an object or surface larger than Medium." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49690d67-4c47-42c4-9c6a-b836954717d3"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
