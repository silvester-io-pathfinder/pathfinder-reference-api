using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrievousBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("3cb24c3f-46b7-4f7f-baca-da48002191b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grievous Blow",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41c80ed4-cd12-4b0c-a57c-0fbbb990edb7"), Type = TextBlockType.Text, Text = "You know how to deliver focused, powerful blows that bypass your enemies’ resistances. Make an unarmed melee (action: Strike). This counts as two attacks when calculating your multiple attack penalty. If this (action: Strike) hits, you deal two extra weapon damage dice. If you are at least 18th level, increase this to three extra weapon damage dice." };
            yield return new TextBlock { Id = Guid.Parse("13731846-e69a-4d13-9d32-5ca140a77aec"), Type = TextBlockType.Text, Text = "This attack also ignores an amount of resistance to physical damage, or to a specific physical damage type, equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5f60caaa-3cac-4a44-bf6a-435b8a388fad"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1f2eb99-f87d-4574-8f47-9a08517f01c7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
