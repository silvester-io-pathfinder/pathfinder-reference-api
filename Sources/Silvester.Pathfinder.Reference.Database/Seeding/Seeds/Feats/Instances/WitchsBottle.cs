using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchsBottle : Template
    {
        public static readonly Guid ID = Guid.Parse("f1a080bb-48e0-4c88-a470-b03fce1ef5aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch's Bottle",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12747d94-50b5-408f-bae8-8a508497d9fa"), Type = TextBlockType.Text, Text = "You spend 10 minutes and 1 Focus Point brewing a special potion containing the power of one of your hexes that targets a creature. A creature that consumes this potion is targeted by the hex. If the hex has a sustained duration and you have (spell: cackle), you can cast (spell: cackle) into the bottle just before you seal it. If you do, the hex’s duration is extended as if you had cast (spell: cackle) the round after the hex was cast (typically this extends the duration by 1 round). Your cackling laugh sounds out when the potion is unsealed." };
            yield return new TextBlock { Id = Guid.Parse("a11154d1-902e-405f-89b0-8b8870324af5"), Type = TextBlockType.Text, Text = "Any potion you create this way loses its power the next time you make your daily preparations. While the potion is in your possession, you can render it inert using a single action that has the (trait: concentrate) trait. You can’t regain the Focus Point you spent to create the potion (or the Focus Point you spent to cast (spell: cackle)) until the potion is consumed or loses its magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("531ecb8e-dfc5-46b3-a70a-748a70768a89"), Feats.Instances.Cauldron.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("061ac8a9-ae5c-41cc-a779-2780a9bea3c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
