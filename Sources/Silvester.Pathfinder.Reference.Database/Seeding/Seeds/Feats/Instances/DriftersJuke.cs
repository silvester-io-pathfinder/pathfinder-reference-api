using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DriftersJuke : Template
    {
        public static readonly Guid ID = Guid.Parse("e50fdff3-3fcc-4006-9626-c4703046668c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drifter's Juke",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c0bcbd4-b69d-4186-8b61-4e418f8a066e"), Type = TextBlockType.Text, Text = "You move in and out of range to complement your attacks. You (action: Step), make a (action: Strike), (action: Step), and make another (action: Strike). One (action: Strike) must be a ranged (action: Strike) using your firearm or crossbow, and the other must be a melee (action: Strike) using your melee weapon or unarmed attack. You can choose not to take one or both (action: Steps|Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("723cb483-2257-482f-8ff7-b53aea323bfe"), GunslingersWays.Instances.WayOfTheDrifter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f36f7ca1-ffc3-48b7-aa49-eb95ab126daf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
