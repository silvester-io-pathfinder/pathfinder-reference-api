using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreciseDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("0328e32b-d362-48ab-b7b4-f9423075df23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Precise Debilitations",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("745cf362-3249-441b-93fc-638cdba51cce"), Type = TextBlockType.Text, Text = "You carefully aim and gracefully deliver your debilitations. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("6077f209-3f6a-4170-b846-7704dfb9b0c5"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target takes an additional 2d6 precision damage from your attacks." };
            yield return new TextBlock { Id = Guid.Parse("9e5d8390-f613-4c19-bce0-0882144100f7"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target becomes flat-footed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("14dd4caf-d517-4177-8df1-187516344e27"), Rackets.Instances.Thief.ID);
            builder.HaveSpecificFeat(Guid.Parse("1b7a87fb-5372-4fe3-8d22-2559c027084c"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("856a1e05-3d44-4543-87af-2a094e0b5d64"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
