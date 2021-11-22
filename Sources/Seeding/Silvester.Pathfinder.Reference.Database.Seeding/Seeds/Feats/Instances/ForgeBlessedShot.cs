using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForgeBlessedShot : Template
    {
        public static readonly Guid ID = Guid.Parse("3895dda0-5435-44c4-80c2-bbfc463d2fad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forge-Blessed Shot",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a ranged Strike.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da1e4e65-1c13-4435-85b2-6b0d60e422ba"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("aa543650-ad5b-46bf-be51-aa7fc344b023"), Type = TextBlockType.Text, Text = "You intone a prayer to the dwarven deities Torag or Angradd, willing a higher power to guide your aim in the heat of battle. On your next (action: Strike) with a ranged weapon before the end of your turn, you gain a +2 circumstance bonus to your attack roll and ignore your target's concealed condition, as well as your target's lesser, standard, and greater cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("cc6436bd-e13d-40ca-9e19-6a1afa003341"), or => 
            {
                or.WorshipSpecificDeity(Guid.Parse("96fe386d-dbd5-4a8c-a2e3-991e50d62662"), Deities.Instances.Torag.ID);
                or.WorshipSpecificDeity(Guid.Parse("a774f647-0366-4546-a5b8-df61691023d8"), Deities.Instances.Angradd.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03d33911-1ba9-46e7-ae65-f4d457fd499d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
