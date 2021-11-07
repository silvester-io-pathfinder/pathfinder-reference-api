using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonStance : Template
    {
        public static readonly Guid ID = Guid.Parse("a56aa5e1-6d8f-42c1-8faa-90bdab4fc3fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4f2bf71-f0d8-4773-8708-9124a969c565"), Type = TextBlockType.Text, Text = "You enter the stance of a dragon and make powerful leg strikes like a lashing dragon’s tail. You can make dragon tail attacks that deal 1d10 bludgeoning damage. They are in the brawling group and have the (trait: backswing), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("7a81b067-8842-48be-8467-3396cd476822"), Type = TextBlockType.Text, Text = "While in Dragon Stance, you can ignore the first square of difficult terrain while (action: Striding | Stride)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("686a6645-5fc7-4ca7-b6ea-9121273e9086"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("849dcaf6-986c-4879-b6d3-fbc20342720f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
