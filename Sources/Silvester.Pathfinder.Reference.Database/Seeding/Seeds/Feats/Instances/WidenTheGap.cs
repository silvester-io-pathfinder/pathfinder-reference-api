using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WidenTheGap : Template
    {
        public static readonly Guid ID = Guid.Parse("fa3b29e9-9bd9-45bf-8db6-47254ca5536b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Widen the Gap",
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
            yield return new TextBlock { Id = Guid.Parse("4e3d635f-33c2-4660-9927-3b445bd1061d"), Type = TextBlockType.Text, Text = "Once you have penetrated a foe’s defenses, you can home in on the same spot to exploit your opponent’s wound and deal some serious damage. The second time you hit and deal damage with a melee axe (action: Strike) to the same opponent or object during your turn, you ignore half of the opponent’s or object’s Hardness, if any. If you hit and deal damage with a melee axe (action: Strike) to the same opponent or object a third or fourth time during your turn, you ignore all of its Hardness, if any." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("af3c9be0-da51-419e-a279-879e04bbc38d"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2011967c-bfa5-42aa-bcaa-99483e78913e"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
