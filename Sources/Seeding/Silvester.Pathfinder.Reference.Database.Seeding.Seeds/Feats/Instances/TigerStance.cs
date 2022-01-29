using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TigerStance : Template
    {
        public static readonly Guid ID = Guid.Parse("1df1c8c8-e4a8-4e76-ac97-4362181ce8a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tiger Stance",
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
            yield return new TextBlock { Id = Guid.Parse("0cd7ed88-44a9-4448-8426-8628508ded82"), Type = TextBlockType.Text, Text = $"You enter the stance of a tiger and can make tiger claw attacks. These deal 1d8 slashing damage; are in the brawling group; and have the {ToMarkdownLink<Models.Entities.Trait>("agile", Traits.Instances.Agile.ID)}, {ToMarkdownLink<Models.Entities.Trait>("finesse", Traits.Instances.Finesse.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits. On a critical success with your tiger claws, if you deal damage, the target takes 1d4 persistent bleed damage." };
            yield return new TextBlock { Id = Guid.Parse("1fd9adde-5ce8-4fe3-b3ee-e21c25898cc1"), Type = TextBlockType.Text, Text = $"As long as your Speed is at least 20 feet while in Tiger Stance, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} 10 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("104697d9-a716-466d-890f-6af23027a3a2"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd9dedfe-6e4e-4f9f-9ffa-eeecf329a15b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
