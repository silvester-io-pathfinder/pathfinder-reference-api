using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FulminatingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("e8a66270-cad7-4ba0-9b2d-5f0915f7a357");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fulminating Shot",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round."
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cea3dae2-5611-4fdf-80b9-e1383d6fc90f"), Type = TextBlockType.Text, Text = $"You channel potent magic into your next shot, empowering it with a blast of crackling energy. Choose acid, cold, electricity, or fire. If you hit with your next attack roll using a firearm or crossbow before the end of your turn, you deal 1d6 additional damage of this type. At 12th level, this increases to 2d6 additional damage, and at 18th level, it increases to 3d6 additional damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e24243c2-1b94-4ffa-85f7-f84d1018dd3a"), Feats.Instances.SpellshotDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcc86b65-392d-433b-aa32-a5b196ae3514"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
