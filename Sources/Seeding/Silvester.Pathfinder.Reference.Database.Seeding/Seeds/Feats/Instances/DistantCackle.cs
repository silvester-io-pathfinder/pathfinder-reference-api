using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistantCackle : Template
    {
        public static readonly Guid ID = Guid.Parse("f9e1202e-7225-4fcf-9db9-e94d62326b88");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distant Cackle",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d015be60-37ae-4794-8caa-ce6243cad8f1"), Type = TextBlockType.Text, Text = "It takes a very brave person to enter the laughter-haunted forest where you dwell. You can cast (spell: ventriloquism) once per day as a 1st-level occult innate spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("a8b121f9-854c-4046-8829-9ae0fc70d716"), Heritages.Instances.WitchGnoll.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ac9efea-5c0c-4052-bb80-f3c9f8fd71ec"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
